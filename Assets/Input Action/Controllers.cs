// GENERATED AUTOMATICALLY FROM 'Assets/Input Action/Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""5e7aad67-b969-45cd-a8f7-005ddb1e11d3"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9923714d-8545-4bee-9cf7-5f543ad950e5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""spawn"",
                    ""type"": ""Button"",
                    ""id"": ""121dfe91-021f-4519-88b5-8ea7750866a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""pause/resume"",
                    ""type"": ""Button"",
                    ""id"": ""3dfa362a-78c8-4534-9995-75338797298f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ziak"",
                    ""type"": ""Button"",
                    ""id"": ""da143161-0f6f-48e4-a93c-e70564687329"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BaseSprite"",
                    ""type"": ""Button"",
                    ""id"": ""c03c6f61-0d89-4d94-91fb-ed639508f673"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""camSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""6fc3a4d5-1f77-4917-b05c-26417c643296"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""56e5a1d6-83e8-406c-a1c0-d03c99174ea9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7027f4c8-0cc1-4554-8f3a-7ddc24fbb8d2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""24644090-819c-4b04-bfa8-ca3b23117005"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a4346447-1632-4353-b60d-a533c3f31d59"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5eb49f0d-1020-42eb-b213-d46c5d00106e"",
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
                    ""id"": ""f562f7e8-890b-4078-8ac6-c6709841f521"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cedc5a14-0d7d-44d7-933a-02cfc6a8bf76"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4d00b7a2-015a-4f1a-8641-a1597388f243"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a2fd418e-af84-47fd-8ba5-14bdba78884c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6978c7cd-a5d0-4b16-89ed-8bacf585f7c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bedfcb87-9f80-48f7-90e9-799ec7a03439"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3628a5c1-922c-44f2-9b15-13921b0455de"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""pause/resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f80a516-50ab-4d1c-9b41-d36648f3d4db"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""pause/resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f734fee6-791f-4deb-bed8-7299385766f3"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""ziak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f8523df-126d-4c56-b776-ca7cfd742022"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""ziak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""083198ad-63a4-4c68-9f98-d305a3735ab3"",
                    ""path"": ""<Keyboard>/quote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""BaseSprite"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b74bb868-e9c3-4d8d-94c7-8d361904dc9e"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""BaseSprite"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49aaf29d-9eb0-4571-a8a9-0e8324efdde9"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""camSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09a1fbb2-3363-43e7-a06e-41cba5ed93a1"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""camSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ebe71c7-cb0e-4e18-be86-1f57f8ac844f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""camSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard/Mouse"",
            ""bindingGroup"": ""Keyboard/Mouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox Controller"",
            ""bindingGroup"": ""Xbox Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
        m_player_spawn = m_player.FindAction("spawn", throwIfNotFound: true);
        m_player_pauseresume = m_player.FindAction("pause/resume", throwIfNotFound: true);
        m_player_ziak = m_player.FindAction("ziak", throwIfNotFound: true);
        m_player_BaseSprite = m_player.FindAction("BaseSprite", throwIfNotFound: true);
        m_player_camSwitch = m_player.FindAction("camSwitch", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_move;
    private readonly InputAction m_player_spawn;
    private readonly InputAction m_player_pauseresume;
    private readonly InputAction m_player_ziak;
    private readonly InputAction m_player_BaseSprite;
    private readonly InputAction m_player_camSwitch;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @spawn => m_Wrapper.m_player_spawn;
        public InputAction @pauseresume => m_Wrapper.m_player_pauseresume;
        public InputAction @ziak => m_Wrapper.m_player_ziak;
        public InputAction @BaseSprite => m_Wrapper.m_player_BaseSprite;
        public InputAction @camSwitch => m_Wrapper.m_player_camSwitch;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @spawn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawn;
                @spawn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawn;
                @spawn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawn;
                @pauseresume.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseresume;
                @pauseresume.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseresume;
                @pauseresume.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseresume;
                @ziak.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZiak;
                @ziak.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZiak;
                @ziak.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZiak;
                @BaseSprite.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBaseSprite;
                @BaseSprite.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBaseSprite;
                @BaseSprite.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBaseSprite;
                @camSwitch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamSwitch;
                @camSwitch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamSwitch;
                @camSwitch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamSwitch;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @spawn.started += instance.OnSpawn;
                @spawn.performed += instance.OnSpawn;
                @spawn.canceled += instance.OnSpawn;
                @pauseresume.started += instance.OnPauseresume;
                @pauseresume.performed += instance.OnPauseresume;
                @pauseresume.canceled += instance.OnPauseresume;
                @ziak.started += instance.OnZiak;
                @ziak.performed += instance.OnZiak;
                @ziak.canceled += instance.OnZiak;
                @BaseSprite.started += instance.OnBaseSprite;
                @BaseSprite.performed += instance.OnBaseSprite;
                @BaseSprite.canceled += instance.OnBaseSprite;
                @camSwitch.started += instance.OnCamSwitch;
                @camSwitch.performed += instance.OnCamSwitch;
                @camSwitch.canceled += instance.OnCamSwitch;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard/Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("Xbox Controller");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSpawn(InputAction.CallbackContext context);
        void OnPauseresume(InputAction.CallbackContext context);
        void OnZiak(InputAction.CallbackContext context);
        void OnBaseSprite(InputAction.CallbackContext context);
        void OnCamSwitch(InputAction.CallbackContext context);
    }
}
