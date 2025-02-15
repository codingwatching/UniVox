// GENERATED AUTOMATICALLY FROM 'Assets/StandardAssets/Characters/Scriptable Objects/Control Map/StandardControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @StandardControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @StandardControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""StandardControls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""65634749-06eb-49be-bc33-237d1110cd9e"",
            ""actions"": [
                {
                    ""name"": ""mouseLook"",
                    ""type"": ""Value"",
                    ""id"": ""8bcd5ab3-6e10-44e8-b7c8-b7822ceaf2a9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""gamepadLook"",
                    ""type"": ""Value"",
                    ""id"": ""d01f4d0b-39c2-4cdd-8b5c-795fed85bf3b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""24ff786e-ba87-4a90-ac39-e8655d3635e0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""crouch"",
                    ""type"": ""Button"",
                    ""id"": ""c54534bb-f30a-457a-b7bb-82fb4bdb41b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""recentre"",
                    ""type"": ""Button"",
                    ""id"": ""03efe845-00ab-4e8f-9e1e-3726eb9bc960"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sprint"",
                    ""type"": ""Button"",
                    ""id"": ""0a324a27-8d7e-4d33-b25a-b6edcfca3a88"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""strafe"",
                    ""type"": ""Button"",
                    ""id"": ""7e03292e-3c45-49c4-b62a-1aae3f0e67f8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""8c88f173-ac42-4036-a5e3-d4d45ac60c1a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3972b889-1874-4d53-b9b1-1c7a02ecce65"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.01,y=0.01)"",
                    ""groups"": """",
                    ""action"": ""mouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85cacec1-b2b4-40eb-bbad-062274fe319e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""gamepadLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6797f34d-9cf8-4fd9-bf7f-8612a221fb78"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""adc73c83-19f4-4d71-8126-33efbb0bf655"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a3e2a044-fa62-41f8-8793-1061a35ac333"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bd1d97fe-b83d-44f8-a87e-10c0db796793"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""be5b2e45-bb2d-46e0-8cc5-dfcc373ed682"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0da3026a-bfd6-4c01-870a-7970d7e648ec"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7b61220b-f3e2-4527-8ac4-463cb3806931"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a2d2357-4c7e-4f2a-871e-f5458c148bcc"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""427dd64f-4bc3-4231-84ca-5eb4e9246712"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""recentre"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91750d8a-70b5-42f7-9060-3150924ab1f5"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""recentre"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c24bfa19-a888-4983-ade9-6058df154c07"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e85d4ce2-c7d7-4a9e-842b-5b6110cc89ca"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b108f8e1-f249-4186-8008-ff46f366162c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6497843a-0ed2-4481-8bd7-257df8919303"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""451c9834-2c5e-45c5-a4ec-2b2c09a2efcb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d9b2eb3-871a-4b37-8acd-b4e91d99d9a0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_mouseLook = m_Movement.FindAction("mouseLook", throwIfNotFound: true);
        m_Movement_gamepadLook = m_Movement.FindAction("gamepadLook", throwIfNotFound: true);
        m_Movement_move = m_Movement.FindAction("move", throwIfNotFound: true);
        m_Movement_crouch = m_Movement.FindAction("crouch", throwIfNotFound: true);
        m_Movement_recentre = m_Movement.FindAction("recentre", throwIfNotFound: true);
        m_Movement_sprint = m_Movement.FindAction("sprint", throwIfNotFound: true);
        m_Movement_strafe = m_Movement.FindAction("strafe", throwIfNotFound: true);
        m_Movement_jump = m_Movement.FindAction("jump", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_mouseLook;
    private readonly InputAction m_Movement_gamepadLook;
    private readonly InputAction m_Movement_move;
    private readonly InputAction m_Movement_crouch;
    private readonly InputAction m_Movement_recentre;
    private readonly InputAction m_Movement_sprint;
    private readonly InputAction m_Movement_strafe;
    private readonly InputAction m_Movement_jump;
    public struct MovementActions
    {
        private @StandardControls m_Wrapper;
        public MovementActions(@StandardControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @mouseLook => m_Wrapper.m_Movement_mouseLook;
        public InputAction @gamepadLook => m_Wrapper.m_Movement_gamepadLook;
        public InputAction @move => m_Wrapper.m_Movement_move;
        public InputAction @crouch => m_Wrapper.m_Movement_crouch;
        public InputAction @recentre => m_Wrapper.m_Movement_recentre;
        public InputAction @sprint => m_Wrapper.m_Movement_sprint;
        public InputAction @strafe => m_Wrapper.m_Movement_strafe;
        public InputAction @jump => m_Wrapper.m_Movement_jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @mouseLook.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseLook;
                @mouseLook.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseLook;
                @mouseLook.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseLook;
                @gamepadLook.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnGamepadLook;
                @gamepadLook.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnGamepadLook;
                @gamepadLook.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnGamepadLook;
                @move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @crouch.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                @crouch.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                @crouch.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                @recentre.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRecentre;
                @recentre.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRecentre;
                @recentre.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRecentre;
                @sprint.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                @sprint.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                @sprint.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                @strafe.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnStrafe;
                @strafe.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnStrafe;
                @strafe.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnStrafe;
                @jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @mouseLook.started += instance.OnMouseLook;
                @mouseLook.performed += instance.OnMouseLook;
                @mouseLook.canceled += instance.OnMouseLook;
                @gamepadLook.started += instance.OnGamepadLook;
                @gamepadLook.performed += instance.OnGamepadLook;
                @gamepadLook.canceled += instance.OnGamepadLook;
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @crouch.started += instance.OnCrouch;
                @crouch.performed += instance.OnCrouch;
                @crouch.canceled += instance.OnCrouch;
                @recentre.started += instance.OnRecentre;
                @recentre.performed += instance.OnRecentre;
                @recentre.canceled += instance.OnRecentre;
                @sprint.started += instance.OnSprint;
                @sprint.performed += instance.OnSprint;
                @sprint.canceled += instance.OnSprint;
                @strafe.started += instance.OnStrafe;
                @strafe.performed += instance.OnStrafe;
                @strafe.canceled += instance.OnStrafe;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnMouseLook(InputAction.CallbackContext context);
        void OnGamepadLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnRecentre(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
