using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using System.Linq;

namespace PG
{
    /// <summary>
    /// Sound effects, using FMOD.
    /// </summary>
    public class VehicleSFX :MonoBehaviour
    {
        [Header("VehicleSFX")]

#pragma warning disable 0649

        [Header("Ground effects")]
        [SerializeField] StudioEventEmitter WheelsEffectEmitterRef;                         //Wheel emitter, for playing slip sounds.

        [Header("Collisions")]
        [SerializeField] float MinTimeBetweenCollisions = 0.1f;
        [SerializeField] float DefaultMagnitudeDivider = 20;                                //default divider to calculate collision volume.
        [SerializeField] EventReference DefaultCollisionEventRef;                           //Event playable if the desired one was not found.      
        [SerializeField] List<ColissionEvent> CollisionEvents = new List<ColissionEvent>();

        [Header("Frictions")]
        [SerializeField] StudioEventEmitter FrictionEffectEmotterRef;
        [SerializeField] float PlayFrictionTime = 0.5f;
        [SerializeField] EventReference DefaultFrictionEventRef;                            //Event playable if the desired one was not found.                        
        [SerializeField] List<ColissionEvent> FrictionEvents = new List<ColissionEvent>();

#pragma warning restore 0649

        //PARAMETER_ID to not use a strings when calling "SetParameter" methods.
        static FMOD.Studio.PARAMETER_ID SlipID;
        static FMOD.Studio.PARAMETER_ID SpeedID;
        static FMOD.Studio.PARAMETER_ID FrictionTimeID;

        Dictionary<FMOD.GUID, WheelSoundData> WheelSounds = new Dictionary<FMOD.GUID, WheelSoundData>();              //Dictionary for playing multiple wheel sounds at the same time.\
        Dictionary<EventReference, FrictionSoundData> FrictionSounds = new Dictionary<EventReference, FrictionSoundData>();     //Dictionary for playing multiple friction sounds at the same time.

        protected VehicleController Vehicle;
        EventReference CurrentFrictionEvent;
        float LastCollisionTime;

        protected event System.Action UpdateAction;

        protected virtual void Start ()
        {
            Vehicle = GetComponentInParent<VehicleController> ();

            if (Vehicle == null)
            {
                Debug.LogErrorFormat ("[{0}] VehicleSFX without VehicleController in parent", name);
                enabled = false;
                return;
            }

            //Subscribe to collisions.
            Vehicle.CollisionAction += PlayCollisionSound;
            Vehicle.CollisionStayAction += PlayCollisionStayAction;

            //Get PARAMETER_ID for all the necessary events.
            FMOD.Studio.PARAMETER_DESCRIPTION paramDescription;

            WheelsEffectEmitterRef.EventDescription.getParameterDescriptionByName ("Slip", out paramDescription);
            SlipID = paramDescription.id;

            WheelsEffectEmitterRef.EventDescription.getParameterDescriptionByName ("Speed", out paramDescription);
            SpeedID = paramDescription.id;

            FrictionEffectEmotterRef.EventDescription.getParameterDescriptionByName ("Time", out paramDescription);
            FrictionTimeID = paramDescription.id;

            //Setting default values.
            WheelsEffectEmitterRef.SetParameter (SlipID, 0);
            WheelsEffectEmitterRef.SetParameter (SpeedID, 0);
            FrictionEffectEmotterRef.SetParameter (SpeedID, 0);
            FrictionEffectEmotterRef.SetParameter (FrictionTimeID, 0);

            WheelSounds.Add (WheelsEffectEmitterRef.EventReference.Guid, new WheelSoundData () { Emitter = WheelsEffectEmitterRef });

            FrictionSounds.Add (FrictionEffectEmotterRef.EventReference, new FrictionSoundData () { Emitter = FrictionEffectEmotterRef, LastFrictionTime = Time.time });
            FrictionEffectEmotterRef.Stop ();

            UpdateAction += UpdateWheels;
            UpdateAction += UpdateFrictions;
        }

        protected virtual void Update ()
        {
            UpdateAction.SafeInvoke ();
        }

        private void OnDestroy ()
        {
            foreach (var soundKV in WheelSounds)
            {
                if (soundKV.Value.Emitter)
                {
                    soundKV.Value.Emitter.Stop ();
                }
            }

            foreach (var soundKV in FrictionSounds)
            {
                if (soundKV.Value.Emitter)
                {
                    soundKV.Value.Emitter.Stop ();
                }
            }
        }

        void UpdateWheels ()
        {
            //Wheels sounds logic.
            //Find the sound for each wheel.
            foreach (var wheel in Vehicle.Wheels)
            {
                if (wheel.IsDead)
                {
                    continue;
                }

                WheelSoundData sound = null;

                if (!WheelSounds.TryGetValue (wheel.CurrentGroundConfig.EventRef.Guid, out sound))
                {
                    var emitter = WheelsEffectEmitterRef.gameObject.AddComponent<StudioEventEmitter>();
                    emitter.EventReference = wheel.CurrentGroundConfig.EventRef;
                    emitter.PlayEvent = WheelsEffectEmitterRef.PlayEvent;
                    emitter.StopEvent = WheelsEffectEmitterRef.StopEvent;
                    sound = new WheelSoundData ()
                    {
                        Emitter = emitter
                    };
                    WheelSounds.Add (wheel.CurrentGroundConfig.EventRef.Guid, sound);
                }

                sound.WheelsCount++;

                //Find the maximum slip for each sound.
                if (wheel.SlipNormalized > sound.Slip)
                {
                    sound.Slip = wheel.SlipNormalized;
                }
            }


            foreach (var sound in WheelSounds)
            {
                //Play or stop events.
                if (sound.Value.WheelsCount == 0)
                {
                    sound.Value.Emitter.Stop ();
                }
                else if (!sound.Value.Emitter.IsPlaying ())
                {
                    sound.Value.Emitter.Play ();
                }

                //Passing parameters to events.
                sound.Value.Emitter.SetParameter (SlipID, sound.Value.Slip);
                sound.Value.Emitter.SetParameter (SpeedID, Vehicle.CurrentSpeed);
                sound.Value.Slip = 0;
                sound.Value.WheelsCount = 0;
            }
        }

        void UpdateFrictions ()
        {
            FrictionSoundData soundData;
            foreach (var sound in FrictionSounds)
            {
                soundData = sound.Value;
                if (soundData.Emitter.IsPlaying ())
                {
                    var time = Time.time - soundData.LastFrictionTime;

                    if (time > PlayFrictionTime)
                    {
                        soundData.Emitter.SetParameter (SpeedID, 0);
                        soundData.Emitter.SetParameter (FrictionTimeID, PlayFrictionTime);
                        soundData.Emitter.Stop ();
                    }
                    else
                    {
                        soundData.Emitter.SetParameter (SpeedID, Vehicle.CurrentSpeed);
                        soundData.Emitter.SetParameter (FrictionTimeID, time);
                    }
                }
            }
        }

        #region Collisions

        /// <summary>
        /// Play collision stay sound.
        /// </summary>
        public void PlayCollisionStayAction (VehicleController vehicle, Collision collision)
        {
            PlayFrictionSound (collision, collision.relativeVelocity.magnitude);
        }

        /// <summary>
        /// Play collision sound.
        /// </summary>
        public void PlayCollisionSound (VehicleController vehicle, Collision collision)
        {
            if (!vehicle.VehicleIsVisible || collision == null)
                return;

            var collisionLayer = collision.gameObject.layer;

            if (Time.time - LastCollisionTime < MinTimeBetweenCollisions)
            {
                return;
            }

            LastCollisionTime = Time.time;
            var collisionMagnitude = collision.relativeVelocity.magnitude;
            float magnitudeDivider;

            if (Vector3.Dot (collision.relativeVelocity.normalized, collision.contacts[0].normal) < 0.2f)
            {
                PlayFrictionSound (collision, collisionMagnitude);
                return;
            }

            var soundEvent = GetEventForCollision (collisionLayer, collisionMagnitude, out magnitudeDivider);

            var volume = Mathf.Clamp01 (collisionMagnitude / magnitudeDivider.Clamp(0, 40));

            FMODExtentions.PlayOneShot (soundEvent, volume, collision.contacts[0].point);
        }

        void PlayFrictionSound (Collision collision, float magnitude)
        {
            if (Vehicle.CurrentSpeed >= 1)
            {
                CurrentFrictionEvent = GetEventForFriction (collision.collider.gameObject.layer, magnitude);

                FrictionSoundData soundData;
                if (!FrictionSounds.TryGetValue (CurrentFrictionEvent, out soundData))
                {
                    var emitter = FrictionEffectEmotterRef.gameObject.AddComponent<StudioEventEmitter>();
                    emitter.EventReference = CurrentFrictionEvent;
                    emitter.PlayEvent = FrictionEffectEmotterRef.PlayEvent;
                    emitter.StopEvent = FrictionEffectEmotterRef.StopEvent;

                    soundData = new FrictionSoundData () { Emitter = emitter };
                    FrictionSounds.Add (CurrentFrictionEvent, soundData);
                }

                if (!soundData.Emitter.IsPlaying ())
                {
                    soundData.Emitter.Play ();
                }

                soundData.LastFrictionTime = Time.time;
            }
        }

        /// <summary>
        /// Search for the desired event based on the collision magnitude and the collision layer.
        /// </summary>
        /// <param name="layer">Collision layer.</param>
        /// <param name="collisionMagnitude">Collision magnitude.</param>
        /// <param name="magnitudeDivider">Divider to calculate collision volume.</param>
        EventReference GetEventForCollision (int layer, float collisionMagnitude, out float magnitudeDivider)
        {
            for (int i = 0; i < CollisionEvents.Count; i++)
            {
                if (CollisionEvents[i].CollisionMask.LayerInMask (layer) && collisionMagnitude >= CollisionEvents[i].MinMagnitudeCollision && collisionMagnitude < CollisionEvents[i].MaxMagnitudeCollision)
                {
                    if (CollisionEvents[i].MaxMagnitudeCollision == float.PositiveInfinity)
                    {
                        magnitudeDivider = DefaultMagnitudeDivider;
                    }
                    else
                    {
                        magnitudeDivider = CollisionEvents[i].MaxMagnitudeCollision;
                    }

                    return CollisionEvents[i].EventRef;
                }
            }

            magnitudeDivider = DefaultMagnitudeDivider;
            return DefaultCollisionEventRef;
        }

        /// <summary>
        /// Search for the desired event based on the friction magnitude and the collision layer.
        /// </summary>
        /// <param name="layer">Collision layer.</param>
        /// <param name="collisionMagnitude">Collision magnitude.</param>
        EventReference GetEventForFriction (int layer, float collisionMagnitude)
        {
            for (int i = 0; i < FrictionEvents.Count; i++)
            {
                if (FrictionEvents[i].CollisionMask.LayerInMask (layer) && collisionMagnitude >= FrictionEvents[i].MinMagnitudeCollision && collisionMagnitude < FrictionEvents[i].MaxMagnitudeCollision)
                {
                    return FrictionEvents[i].EventRef;
                }
            }

            return DefaultFrictionEventRef;
        }

        #endregion //Collisions

        [System.Serializable]
        public struct ColissionEvent
        {
            public EventReference EventRef;
            public LayerMask CollisionMask;
            public float MinMagnitudeCollision;
            public float MaxMagnitudeCollision;
        }

        public class FrictionSoundData
        {
            public StudioEventEmitter Emitter;
            public float LastFrictionTime;
        }

        public class WheelSoundData
        {
            public StudioEventEmitter Emitter;
            public float Slip;
            public int WheelsCount;
        }
    }
}
