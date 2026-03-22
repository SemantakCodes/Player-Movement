using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateManager : MonoBehaviour
{
    PlayerBaseState currentState;
    public PlayerJumpState jumpState = new PlayerJumpState();
    public PlayerSprintState sprintState = new PlayerSprintState();
    public PlayerWalkState walkState = new PlayerWalkState();
    public PlayerIdleState idleState = new PlayerIdleState();


    // Uni Variables Zone
    [SerializeField] private CharacterController charController;
    //Loading the actions
    private InputAction moveAction;
    private InputAction jumpAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
        //Reading the actions
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }
    
    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
        
    }

    public void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
