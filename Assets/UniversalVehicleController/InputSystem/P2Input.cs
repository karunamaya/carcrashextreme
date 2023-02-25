//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/UniversalVehicleController/InputSystem/P2Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace PG
{
    public partial class @P2Input : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @P2Input()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""P2Input"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""17a1c5c9-dfec-4fad-abfc-f3ffd54be7cb"",
            ""actions"": [
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""bd270d84-c64d-44a9-b675-344ff975f1d0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BrakeReverse"",
                    ""type"": ""Value"",
                    ""id"": ""fbd23568-4ab1-4c9b-8a48-94e92d79a42d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""b92ffef5-7949-4616-b637-28b04e8ac690"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Button"",
                    ""id"": ""dc850edb-db98-4d06-89c4-05c1aee99966"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HandBrake"",
                    ""type"": ""Button"",
                    ""id"": ""4769c531-f278-4107-b84c-ac5863acbb8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NextGear"",
                    ""type"": ""Button"",
                    ""id"": ""044b2a1a-94de-4313-b4c4-bf2a3bd345d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrevGear"",
                    ""type"": ""Button"",
                    ""id"": ""61d07b70-992a-4d24-8b3b-4724fdd16eb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lights"",
                    ""type"": ""Button"",
                    ""id"": ""e8c056fc-5457-4c82-848f-eea0e45a68dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftTurnSignal"",
                    ""type"": ""Button"",
                    ""id"": ""dd6f791f-30cd-42b9-88a9-acbbeef385a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightTurnSignal"",
                    ""type"": ""Button"",
                    ""id"": ""d4106a27-89b5-4fd6-893f-fecd1f567935"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Alarm"",
                    ""type"": ""Button"",
                    ""id"": ""1e5fc0e0-b45c-4273-8714-68c03801d478"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ResetCar"",
                    ""type"": ""Button"",
                    ""id"": ""f77d0c40-d2b2-4996-8204-ca45b3d1c846"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeView"",
                    ""type"": ""Button"",
                    ""id"": ""cc1bfb8c-7271-47eb-8d9e-76b14bbfa75c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ViewDelta"",
                    ""type"": ""Value"",
                    ""id"": ""24ad352b-01fb-4bf1-a8cd-b81de160d4ab"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ConnectTrailer"",
                    ""type"": ""Button"",
                    ""id"": ""fde146cd-9637-430b-b369-e58f9c8f1c7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""cfc72dab-5bd2-4569-ae2b-9aab752caad8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3cdd121d-a16a-4677-907d-ca6cf92a4dad"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e198f171-6a14-43de-9bbe-52d395850a0f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84bb6f3c-8119-45c3-be2c-db1801f47000"",
                    ""path"": ""<Keyboard>/numpadMultiply"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ccb0678-181f-435e-90ef-c94e2dbcd477"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98dc2f2f-882b-4942-8c61-847b89fb5eec"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftTurnSignal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ffe477b-1647-452f-a8b7-21ffbbb65e84"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeftTurnSignal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b283106-65eb-4e32-8761-2c4ec56f713c"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightTurnSignal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1931c711-d447-4eb3-93c4-b629cec70df0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RightTurnSignal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0b88622-567e-4e1c-9ba9-967ace76570e"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Alarm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""375a4e5f-0de2-4855-8f2e-8fec1e32dc36"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Alarm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd324821-1c2b-4de4-8b2d-fff0f62a72d5"",
                    ""path"": ""<Keyboard>/numpadDivide"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ResetCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c2b9f82-b48b-430e-9f2c-12381d4eb1fd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ResetCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""622f08e5-5d1f-413f-bbb6-03d5d09adb73"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af665a0e-00c5-44dc-ab11-566fcc425085"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4369001f-28a1-46d8-ae3a-dae515a59ee0"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=5,y=5)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ViewDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07f4bc6f-6fb9-45ae-96cb-5ee239d86137"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f292078-11f3-4525-b194-a680f9a2e032"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a09449fb-ece1-416b-bc64-876cd854697e"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BrakeReverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07bd19ab-4187-4835-bdc0-005096afec86"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BrakeReverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d508fd98-1cb9-4857-a7ab-444be11ffcb7"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""NextGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f59b9e3-6139-4b50-8d1e-c3f155a881bd"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NextGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba7f7fba-27e2-4099-abc7-0ce3a946eae7"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PrevGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69e7060d-6a4f-4c1f-b056-3e8668a89aa2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PrevGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b4c1fda-4de2-49cd-babc-5ebbad080b8d"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ConnectTrailer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a9653d3-986e-4422-bcbd-e9fd129e5570"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ConnectTrailer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ff5de4d-35fa-43a0-bf1b-e2f43e1330a2"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d6675167-8bdb-4b2e-9c0f-23c3117332d6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""10bcb06d-75fd-4d21-8fe8-f3e0b33f763d"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a8c5329d-87b6-4c94-b74d-a033873ecfbe"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""652d464b-e239-4d27-9909-e2d562b5c243"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""290f7eea-29ce-4106-8fa2-f550c4590e68"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fba8ff95-ee58-4759-83dd-e0bded520ec5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d64f32a4-c638-43e4-9bde-48a4d1b8e782"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.3,max=0.6)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dd855ae1-06df-4e95-8bc5-5e1af9c29d6c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.3,max=0.6)"",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Input
            m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
            m_Input_Acceleration = m_Input.FindAction("Acceleration", throwIfNotFound: true);
            m_Input_BrakeReverse = m_Input.FindAction("BrakeReverse", throwIfNotFound: true);
            m_Input_Steer = m_Input.FindAction("Steer", throwIfNotFound: true);
            m_Input_Pitch = m_Input.FindAction("Pitch", throwIfNotFound: true);
            m_Input_HandBrake = m_Input.FindAction("HandBrake", throwIfNotFound: true);
            m_Input_NextGear = m_Input.FindAction("NextGear", throwIfNotFound: true);
            m_Input_PrevGear = m_Input.FindAction("PrevGear", throwIfNotFound: true);
            m_Input_Lights = m_Input.FindAction("Lights", throwIfNotFound: true);
            m_Input_LeftTurnSignal = m_Input.FindAction("LeftTurnSignal", throwIfNotFound: true);
            m_Input_RightTurnSignal = m_Input.FindAction("RightTurnSignal", throwIfNotFound: true);
            m_Input_Alarm = m_Input.FindAction("Alarm", throwIfNotFound: true);
            m_Input_ResetCar = m_Input.FindAction("ResetCar", throwIfNotFound: true);
            m_Input_ChangeView = m_Input.FindAction("ChangeView", throwIfNotFound: true);
            m_Input_ViewDelta = m_Input.FindAction("ViewDelta", throwIfNotFound: true);
            m_Input_ConnectTrailer = m_Input.FindAction("ConnectTrailer", throwIfNotFound: true);
            m_Input_Boost = m_Input.FindAction("Boost", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Input
        private readonly InputActionMap m_Input;
        private IInputActions m_InputActionsCallbackInterface;
        private readonly InputAction m_Input_Acceleration;
        private readonly InputAction m_Input_BrakeReverse;
        private readonly InputAction m_Input_Steer;
        private readonly InputAction m_Input_Pitch;
        private readonly InputAction m_Input_HandBrake;
        private readonly InputAction m_Input_NextGear;
        private readonly InputAction m_Input_PrevGear;
        private readonly InputAction m_Input_Lights;
        private readonly InputAction m_Input_LeftTurnSignal;
        private readonly InputAction m_Input_RightTurnSignal;
        private readonly InputAction m_Input_Alarm;
        private readonly InputAction m_Input_ResetCar;
        private readonly InputAction m_Input_ChangeView;
        private readonly InputAction m_Input_ViewDelta;
        private readonly InputAction m_Input_ConnectTrailer;
        private readonly InputAction m_Input_Boost;
        public struct InputActions
        {
            private @P2Input m_Wrapper;
            public InputActions(@P2Input wrapper) { m_Wrapper = wrapper; }
            public InputAction @Acceleration => m_Wrapper.m_Input_Acceleration;
            public InputAction @BrakeReverse => m_Wrapper.m_Input_BrakeReverse;
            public InputAction @Steer => m_Wrapper.m_Input_Steer;
            public InputAction @Pitch => m_Wrapper.m_Input_Pitch;
            public InputAction @HandBrake => m_Wrapper.m_Input_HandBrake;
            public InputAction @NextGear => m_Wrapper.m_Input_NextGear;
            public InputAction @PrevGear => m_Wrapper.m_Input_PrevGear;
            public InputAction @Lights => m_Wrapper.m_Input_Lights;
            public InputAction @LeftTurnSignal => m_Wrapper.m_Input_LeftTurnSignal;
            public InputAction @RightTurnSignal => m_Wrapper.m_Input_RightTurnSignal;
            public InputAction @Alarm => m_Wrapper.m_Input_Alarm;
            public InputAction @ResetCar => m_Wrapper.m_Input_ResetCar;
            public InputAction @ChangeView => m_Wrapper.m_Input_ChangeView;
            public InputAction @ViewDelta => m_Wrapper.m_Input_ViewDelta;
            public InputAction @ConnectTrailer => m_Wrapper.m_Input_ConnectTrailer;
            public InputAction @Boost => m_Wrapper.m_Input_Boost;
            public InputActionMap Get() { return m_Wrapper.m_Input; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
            public void SetCallbacks(IInputActions instance)
            {
                if (m_Wrapper.m_InputActionsCallbackInterface != null)
                {
                    @Acceleration.started -= m_Wrapper.m_InputActionsCallbackInterface.OnAcceleration;
                    @Acceleration.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnAcceleration;
                    @Acceleration.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnAcceleration;
                    @BrakeReverse.started -= m_Wrapper.m_InputActionsCallbackInterface.OnBrakeReverse;
                    @BrakeReverse.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnBrakeReverse;
                    @BrakeReverse.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnBrakeReverse;
                    @Steer.started -= m_Wrapper.m_InputActionsCallbackInterface.OnSteer;
                    @Steer.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnSteer;
                    @Steer.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnSteer;
                    @Pitch.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPitch;
                    @Pitch.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPitch;
                    @Pitch.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPitch;
                    @HandBrake.started -= m_Wrapper.m_InputActionsCallbackInterface.OnHandBrake;
                    @HandBrake.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnHandBrake;
                    @HandBrake.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnHandBrake;
                    @NextGear.started -= m_Wrapper.m_InputActionsCallbackInterface.OnNextGear;
                    @NextGear.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnNextGear;
                    @NextGear.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnNextGear;
                    @PrevGear.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPrevGear;
                    @PrevGear.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPrevGear;
                    @PrevGear.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPrevGear;
                    @Lights.started -= m_Wrapper.m_InputActionsCallbackInterface.OnLights;
                    @Lights.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnLights;
                    @Lights.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnLights;
                    @LeftTurnSignal.started -= m_Wrapper.m_InputActionsCallbackInterface.OnLeftTurnSignal;
                    @LeftTurnSignal.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnLeftTurnSignal;
                    @LeftTurnSignal.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnLeftTurnSignal;
                    @RightTurnSignal.started -= m_Wrapper.m_InputActionsCallbackInterface.OnRightTurnSignal;
                    @RightTurnSignal.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnRightTurnSignal;
                    @RightTurnSignal.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnRightTurnSignal;
                    @Alarm.started -= m_Wrapper.m_InputActionsCallbackInterface.OnAlarm;
                    @Alarm.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnAlarm;
                    @Alarm.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnAlarm;
                    @ResetCar.started -= m_Wrapper.m_InputActionsCallbackInterface.OnResetCar;
                    @ResetCar.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnResetCar;
                    @ResetCar.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnResetCar;
                    @ChangeView.started -= m_Wrapper.m_InputActionsCallbackInterface.OnChangeView;
                    @ChangeView.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnChangeView;
                    @ChangeView.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnChangeView;
                    @ViewDelta.started -= m_Wrapper.m_InputActionsCallbackInterface.OnViewDelta;
                    @ViewDelta.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnViewDelta;
                    @ViewDelta.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnViewDelta;
                    @ConnectTrailer.started -= m_Wrapper.m_InputActionsCallbackInterface.OnConnectTrailer;
                    @ConnectTrailer.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnConnectTrailer;
                    @ConnectTrailer.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnConnectTrailer;
                    @Boost.started -= m_Wrapper.m_InputActionsCallbackInterface.OnBoost;
                    @Boost.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnBoost;
                    @Boost.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnBoost;
                }
                m_Wrapper.m_InputActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Acceleration.started += instance.OnAcceleration;
                    @Acceleration.performed += instance.OnAcceleration;
                    @Acceleration.canceled += instance.OnAcceleration;
                    @BrakeReverse.started += instance.OnBrakeReverse;
                    @BrakeReverse.performed += instance.OnBrakeReverse;
                    @BrakeReverse.canceled += instance.OnBrakeReverse;
                    @Steer.started += instance.OnSteer;
                    @Steer.performed += instance.OnSteer;
                    @Steer.canceled += instance.OnSteer;
                    @Pitch.started += instance.OnPitch;
                    @Pitch.performed += instance.OnPitch;
                    @Pitch.canceled += instance.OnPitch;
                    @HandBrake.started += instance.OnHandBrake;
                    @HandBrake.performed += instance.OnHandBrake;
                    @HandBrake.canceled += instance.OnHandBrake;
                    @NextGear.started += instance.OnNextGear;
                    @NextGear.performed += instance.OnNextGear;
                    @NextGear.canceled += instance.OnNextGear;
                    @PrevGear.started += instance.OnPrevGear;
                    @PrevGear.performed += instance.OnPrevGear;
                    @PrevGear.canceled += instance.OnPrevGear;
                    @Lights.started += instance.OnLights;
                    @Lights.performed += instance.OnLights;
                    @Lights.canceled += instance.OnLights;
                    @LeftTurnSignal.started += instance.OnLeftTurnSignal;
                    @LeftTurnSignal.performed += instance.OnLeftTurnSignal;
                    @LeftTurnSignal.canceled += instance.OnLeftTurnSignal;
                    @RightTurnSignal.started += instance.OnRightTurnSignal;
                    @RightTurnSignal.performed += instance.OnRightTurnSignal;
                    @RightTurnSignal.canceled += instance.OnRightTurnSignal;
                    @Alarm.started += instance.OnAlarm;
                    @Alarm.performed += instance.OnAlarm;
                    @Alarm.canceled += instance.OnAlarm;
                    @ResetCar.started += instance.OnResetCar;
                    @ResetCar.performed += instance.OnResetCar;
                    @ResetCar.canceled += instance.OnResetCar;
                    @ChangeView.started += instance.OnChangeView;
                    @ChangeView.performed += instance.OnChangeView;
                    @ChangeView.canceled += instance.OnChangeView;
                    @ViewDelta.started += instance.OnViewDelta;
                    @ViewDelta.performed += instance.OnViewDelta;
                    @ViewDelta.canceled += instance.OnViewDelta;
                    @ConnectTrailer.started += instance.OnConnectTrailer;
                    @ConnectTrailer.performed += instance.OnConnectTrailer;
                    @ConnectTrailer.canceled += instance.OnConnectTrailer;
                    @Boost.started += instance.OnBoost;
                    @Boost.performed += instance.OnBoost;
                    @Boost.canceled += instance.OnBoost;
                }
            }
        }
        public InputActions @Input => new InputActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_KeyboardSchemeIndex = -1;
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
            }
        }
        public interface IInputActions
        {
            void OnAcceleration(InputAction.CallbackContext context);
            void OnBrakeReverse(InputAction.CallbackContext context);
            void OnSteer(InputAction.CallbackContext context);
            void OnPitch(InputAction.CallbackContext context);
            void OnHandBrake(InputAction.CallbackContext context);
            void OnNextGear(InputAction.CallbackContext context);
            void OnPrevGear(InputAction.CallbackContext context);
            void OnLights(InputAction.CallbackContext context);
            void OnLeftTurnSignal(InputAction.CallbackContext context);
            void OnRightTurnSignal(InputAction.CallbackContext context);
            void OnAlarm(InputAction.CallbackContext context);
            void OnResetCar(InputAction.CallbackContext context);
            void OnChangeView(InputAction.CallbackContext context);
            void OnViewDelta(InputAction.CallbackContext context);
            void OnConnectTrailer(InputAction.CallbackContext context);
            void OnBoost(InputAction.CallbackContext context);
        }
    }
}
