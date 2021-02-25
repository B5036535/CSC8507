// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Old/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerInputs"",
            ""id"": ""4e8ebb85-7e7b-4639-86bb-37e4e9368496"",
            ""actions"": [
                {
                    ""name"": ""Running"",
                    ""type"": ""Value"",
                    ""id"": ""16218891-50aa-41cf-b64f-5e310506ccba"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5031bc64-8e66-4c29-8654-e914e0827f3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""ecfec50c-ac46-44ac-bbee-eb9441dd385c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6b788996-ba49-4a1d-98a6-619ba4688631"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Running"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""13708e5f-0307-44f6-827f-1a65bcb977b1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""36ccae63-31e7-48cc-aed8-c04f7fe3abe3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""836d1b4a-bccc-43c8-a6aa-ac18ce75b3d2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a0a23a62-059a-4d7e-8394-5901174e4783"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""46a5c0f2-43dc-4ed5-a6da-8e65f9820332"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c19dd1f-44a2-4c03-acbc-65d08f3f1df1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""64541426-e398-4d22-bc52-b28b59eacc09"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ab47c173-593e-4300-b5ae-f19b4a20331c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""004739bf-cf6e-468e-9ccb-fa725ae96f07"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInputs
        m_PlayerInputs = asset.FindActionMap("PlayerInputs", throwIfNotFound: true);
        m_PlayerInputs_Running = m_PlayerInputs.FindAction("Running", throwIfNotFound: true);
        m_PlayerInputs_Jump = m_PlayerInputs.FindAction("Jump", throwIfNotFound: true);
        m_PlayerInputs_Respawn = m_PlayerInputs.FindAction("Respawn", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Look = m_Mouse.FindAction("Look", throwIfNotFound: true);
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

    // PlayerInputs
    private readonly InputActionMap m_PlayerInputs;
    private IPlayerInputsActions m_PlayerInputsActionsCallbackInterface;
    private readonly InputAction m_PlayerInputs_Running;
    private readonly InputAction m_PlayerInputs_Jump;
    private readonly InputAction m_PlayerInputs_Respawn;
    public struct PlayerInputsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerInputsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Running => m_Wrapper.m_PlayerInputs_Running;
        public InputAction @Jump => m_Wrapper.m_PlayerInputs_Jump;
        public InputAction @Respawn => m_Wrapper.m_PlayerInputs_Respawn;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputsActions instance)
        {
            if (m_Wrapper.m_PlayerInputsActionsCallbackInterface != null)
            {
                @Running.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRunning;
                @Running.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRunning;
                @Running.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRunning;
                @Jump.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnJump;
                @Respawn.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRespawn;
                @Respawn.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRespawn;
                @Respawn.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRespawn;
            }
            m_Wrapper.m_PlayerInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Running.started += instance.OnRunning;
                @Running.performed += instance.OnRunning;
                @Running.canceled += instance.OnRunning;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Respawn.started += instance.OnRespawn;
                @Respawn.performed += instance.OnRespawn;
                @Respawn.canceled += instance.OnRespawn;
            }
        }
    }
    public PlayerInputsActions @PlayerInputs => new PlayerInputsActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Look;
    public struct MouseActions
    {
        private @PlayerControls m_Wrapper;
        public MouseActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Mouse_Look;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface IPlayerInputsActions
    {
        void OnRunning(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRespawn(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnLook(InputAction.CallbackContext context);
    }
}
