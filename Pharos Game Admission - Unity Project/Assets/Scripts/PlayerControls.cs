// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""d6aba934-fc0e-4663-bb69-2fa404c11d07"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""85d23b74-e10f-4d49-b4f9-07fa8c87122d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BasicAttack"",
                    ""type"": ""Button"",
                    ""id"": ""16f9d2fe-9bfb-475b-a9e4-b196931adcf0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""0787b92f-0f2c-4b1b-bce8-c1177e3f9570"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""f7d63c77-6590-413d-8799-2f65303944e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4363735c-0637-48e9-87d6-1c5d5b2544cb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""14936a65-55d9-40d4-b4a6-cec801901f85"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""858e9846-4b8f-4b9a-b533-ba70be705e99"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85bcfb56-4c1b-4209-a3eb-dcbe46d2464e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb883706-ab0f-4e5d-8b8e-f877e3d4fecc"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c183547-fecb-4c2e-8412-62b31b0d51b5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94226424-eb6d-47d8-af5e-af9d6ad9f898"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8337628b-c847-4dd7-ae74-05e6c1f672e7"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7620073-36f7-4288-865a-2e5f27342dce"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a551ddd8-5d4f-49a0-8faf-e62f5df2362a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55e24058-1cdf-4636-86f4-1dcc378f4c10"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00e44995-2634-4d21-972b-19b654a98fbc"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a16f2b2a-5700-4f02-b732-4348e1094492"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e8502c9-51db-4b1a-b0a2-385cdaae3c62"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Move = m_Gameplay.GetAction("Move");
        m_Gameplay_BasicAttack = m_Gameplay.GetAction("BasicAttack");
        m_Gameplay_Quit = m_Gameplay.GetAction("Quit");
        m_Gameplay_MoveRight = m_Gameplay.GetAction("MoveRight");
        m_Gameplay_MoveLeft = m_Gameplay.GetAction("MoveLeft");
        m_Gameplay_Dash = m_Gameplay.GetAction("Dash");
        m_Gameplay_Jump = m_Gameplay.GetAction("Jump");
    }

    ~PlayerControls()
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_BasicAttack;
    private readonly InputAction m_Gameplay_Quit;
    private readonly InputAction m_Gameplay_MoveRight;
    private readonly InputAction m_Gameplay_MoveLeft;
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_Jump;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @BasicAttack => m_Wrapper.m_Gameplay_BasicAttack;
        public InputAction @Quit => m_Wrapper.m_Gameplay_Quit;
        public InputAction @MoveRight => m_Wrapper.m_Gameplay_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_Gameplay_MoveLeft;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                BasicAttack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBasicAttack;
                BasicAttack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBasicAttack;
                BasicAttack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBasicAttack;
                Quit.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit;
                Quit.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit;
                Quit.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit;
                MoveRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                MoveRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                MoveRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                MoveLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                MoveLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                MoveLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                BasicAttack.started += instance.OnBasicAttack;
                BasicAttack.performed += instance.OnBasicAttack;
                BasicAttack.canceled += instance.OnBasicAttack;
                Quit.started += instance.OnQuit;
                Quit.performed += instance.OnQuit;
                Quit.canceled += instance.OnQuit;
                MoveRight.started += instance.OnMoveRight;
                MoveRight.performed += instance.OnMoveRight;
                MoveRight.canceled += instance.OnMoveRight;
                MoveLeft.started += instance.OnMoveLeft;
                MoveLeft.performed += instance.OnMoveLeft;
                MoveLeft.canceled += instance.OnMoveLeft;
                Dash.started += instance.OnDash;
                Dash.performed += instance.OnDash;
                Dash.canceled += instance.OnDash;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnBasicAttack(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
