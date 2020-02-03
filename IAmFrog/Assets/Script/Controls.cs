// GENERATED AUTOMATICALLY FROM 'Assets/Script/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""f0cca347-8182-4d2f-a96b-de749f17f57a"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""5ea6827d-c20c-43df-a095-157ffa8cf4ca"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""0610ca1e-6646-4c74-a656-30c0e9aa46bf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""e4b4401d-8201-40f2-b834-3d0466a39865"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9079e43d-c9d1-47a1-8925-404f6e2eff8e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tongue"",
                    ""type"": ""Button"",
                    ""id"": ""26ac52ea-ee12-4abd-b621-d3c2c9b6b274"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""12d8e23b-1027-44ef-ad70-367eda8596c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b4004a2-08b1-4b63-832b-8dd136f4a474"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e15542f-72ed-4688-9174-1f04d5ec8e1c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaa721e3-0360-4191-ad7d-44e2679bfd6c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70c46146-2882-4d55-80b8-f4e306c44092"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tongue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Forward = m_PlayerControls.FindAction("Forward", throwIfNotFound: true);
        m_PlayerControls_Left = m_PlayerControls.FindAction("Left", throwIfNotFound: true);
        m_PlayerControls_Right = m_PlayerControls.FindAction("Right", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_Tongue = m_PlayerControls.FindAction("Tongue", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Forward;
    private readonly InputAction m_PlayerControls_Left;
    private readonly InputAction m_PlayerControls_Right;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Tongue;
    public struct PlayerControlsActions
    {
        private @Controls m_Wrapper;
        public PlayerControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_PlayerControls_Forward;
        public InputAction @Left => m_Wrapper.m_PlayerControls_Left;
        public InputAction @Right => m_Wrapper.m_PlayerControls_Right;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @Tongue => m_Wrapper.m_PlayerControls_Tongue;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Forward.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnForward;
                @Left.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRight;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Tongue.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTongue;
                @Tongue.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTongue;
                @Tongue.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTongue;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Tongue.started += instance.OnTongue;
                @Tongue.performed += instance.OnTongue;
                @Tongue.canceled += instance.OnTongue;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTongue(InputAction.CallbackContext context);
    }
}
