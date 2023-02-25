using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FMODUnity
{
	public class FMODExtentions
	{
		public static void PlayOneShot (EventReference eventRef, float volume, Vector3 position = new Vector3 ())
		{
            if (eventRef.IsNull)
            {
#if UNITY_EDITOR
                Debug.LogWarning ("[FMOD] Event not found: " + eventRef.Path);
#else
                Debug.LogWarning ("[FMOD] Event not found");
#endif
            }
            else
            {
                try
                {
                    var instance = RuntimeManager.CreateInstance(eventRef);
                    instance.set3DAttributes (RuntimeUtils.To3DAttributes (position));
                    instance.setVolume (volume);
                    instance.start ();
                    instance.release ();
                }
                catch (EventNotFoundException)
                {
#if UNITY_EDITOR
                    Debug.LogWarning ("[FMOD] Event not found: " + eventRef.Path);
#else
                    Debug.LogWarning ("[FMOD] Event not found");
#endif
                }
            }
        }
	}
}
