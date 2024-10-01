//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Topics/Strategy/Input/AbilityInputActions.inputactions
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

public partial class @AbilityInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @AbilityInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""AbilityInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerAbilityMap"",
            ""id"": ""f8f7545b-ac2b-4e3d-8bbe-17aa312c7ca4"",
            ""actions"": [
                {
                    ""name"": ""ChooseAbility1"",
                    ""type"": ""Button"",
                    ""id"": ""5eb7e62d-0dea-4fe9-9836-1de562229ee3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChooseAbility2"",
                    ""type"": ""Button"",
                    ""id"": ""a6db03bb-fd09-43a5-aa9f-c43179f3253e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChooseAbility3"",
                    ""type"": ""Button"",
                    ""id"": ""40bf688d-44d0-472d-8c1d-8eef8c605ea5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChooseAbility4"",
                    ""type"": ""Button"",
                    ""id"": ""7c933393-4281-4f2d-ade0-053e89954e4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseAbility"",
                    ""type"": ""Button"",
                    ""id"": ""7f639cc5-8fc2-46e7-81fe-6a2e689054b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""583d7e78-da65-4242-97f1-9c1dbcb05965"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc330348-6838-4b71-9ced-822f80158787"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseAbility1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78913aa8-87f3-4aa1-ba83-8d379983b154"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseAbility2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc92ef58-3cbe-42d6-b25c-e58e110f45fb"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseAbility3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2751f470-ab4e-465a-9494-3e3fd0251891"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseAbility4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // PlayerAbilityMap
        m_PlayerAbilityMap = asset.FindActionMap("PlayerAbilityMap", throwIfNotFound: true);
        m_PlayerAbilityMap_ChooseAbility1 = m_PlayerAbilityMap.FindAction("ChooseAbility1", throwIfNotFound: true);
        m_PlayerAbilityMap_ChooseAbility2 = m_PlayerAbilityMap.FindAction("ChooseAbility2", throwIfNotFound: true);
        m_PlayerAbilityMap_ChooseAbility3 = m_PlayerAbilityMap.FindAction("ChooseAbility3", throwIfNotFound: true);
        m_PlayerAbilityMap_ChooseAbility4 = m_PlayerAbilityMap.FindAction("ChooseAbility4", throwIfNotFound: true);
        m_PlayerAbilityMap_UseAbility = m_PlayerAbilityMap.FindAction("UseAbility", throwIfNotFound: true);
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

    // PlayerAbilityMap
    private readonly InputActionMap m_PlayerAbilityMap;
    private List<IPlayerAbilityMapActions> m_PlayerAbilityMapActionsCallbackInterfaces = new List<IPlayerAbilityMapActions>();
    private readonly InputAction m_PlayerAbilityMap_ChooseAbility1;
    private readonly InputAction m_PlayerAbilityMap_ChooseAbility2;
    private readonly InputAction m_PlayerAbilityMap_ChooseAbility3;
    private readonly InputAction m_PlayerAbilityMap_ChooseAbility4;
    private readonly InputAction m_PlayerAbilityMap_UseAbility;
    public struct PlayerAbilityMapActions
    {
        private @AbilityInputActions m_Wrapper;
        public PlayerAbilityMapActions(@AbilityInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChooseAbility1 => m_Wrapper.m_PlayerAbilityMap_ChooseAbility1;
        public InputAction @ChooseAbility2 => m_Wrapper.m_PlayerAbilityMap_ChooseAbility2;
        public InputAction @ChooseAbility3 => m_Wrapper.m_PlayerAbilityMap_ChooseAbility3;
        public InputAction @ChooseAbility4 => m_Wrapper.m_PlayerAbilityMap_ChooseAbility4;
        public InputAction @UseAbility => m_Wrapper.m_PlayerAbilityMap_UseAbility;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAbilityMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerAbilityMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerAbilityMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerAbilityMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerAbilityMapActionsCallbackInterfaces.Add(instance);
            @ChooseAbility1.started += instance.OnChooseAbility1;
            @ChooseAbility1.performed += instance.OnChooseAbility1;
            @ChooseAbility1.canceled += instance.OnChooseAbility1;
            @ChooseAbility2.started += instance.OnChooseAbility2;
            @ChooseAbility2.performed += instance.OnChooseAbility2;
            @ChooseAbility2.canceled += instance.OnChooseAbility2;
            @ChooseAbility3.started += instance.OnChooseAbility3;
            @ChooseAbility3.performed += instance.OnChooseAbility3;
            @ChooseAbility3.canceled += instance.OnChooseAbility3;
            @ChooseAbility4.started += instance.OnChooseAbility4;
            @ChooseAbility4.performed += instance.OnChooseAbility4;
            @ChooseAbility4.canceled += instance.OnChooseAbility4;
            @UseAbility.started += instance.OnUseAbility;
            @UseAbility.performed += instance.OnUseAbility;
            @UseAbility.canceled += instance.OnUseAbility;
        }

        private void UnregisterCallbacks(IPlayerAbilityMapActions instance)
        {
            @ChooseAbility1.started -= instance.OnChooseAbility1;
            @ChooseAbility1.performed -= instance.OnChooseAbility1;
            @ChooseAbility1.canceled -= instance.OnChooseAbility1;
            @ChooseAbility2.started -= instance.OnChooseAbility2;
            @ChooseAbility2.performed -= instance.OnChooseAbility2;
            @ChooseAbility2.canceled -= instance.OnChooseAbility2;
            @ChooseAbility3.started -= instance.OnChooseAbility3;
            @ChooseAbility3.performed -= instance.OnChooseAbility3;
            @ChooseAbility3.canceled -= instance.OnChooseAbility3;
            @ChooseAbility4.started -= instance.OnChooseAbility4;
            @ChooseAbility4.performed -= instance.OnChooseAbility4;
            @ChooseAbility4.canceled -= instance.OnChooseAbility4;
            @UseAbility.started -= instance.OnUseAbility;
            @UseAbility.performed -= instance.OnUseAbility;
            @UseAbility.canceled -= instance.OnUseAbility;
        }

        public void RemoveCallbacks(IPlayerAbilityMapActions instance)
        {
            if (m_Wrapper.m_PlayerAbilityMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerAbilityMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerAbilityMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerAbilityMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerAbilityMapActions @PlayerAbilityMap => new PlayerAbilityMapActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerAbilityMapActions
    {
        void OnChooseAbility1(InputAction.CallbackContext context);
        void OnChooseAbility2(InputAction.CallbackContext context);
        void OnChooseAbility3(InputAction.CallbackContext context);
        void OnChooseAbility4(InputAction.CallbackContext context);
        void OnUseAbility(InputAction.CallbackContext context);
    }
}