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
    [SerializeField] private InputAction moveAction;
    [SerializeField] private InputAction jumpAction;
    
    public Vector3 newMoveValue;
    public Vector3 move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
        //Reading the actions
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        moveAction.Enable();
        jumpAction.Enable();
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        newMoveValue.x = input.x;
        newMoveValue.y = 0;
        newMoveValue.z = input.y;
        move = Vector3.ClampMagnitude(newMoveValue, 1f);        
        currentState.UpdateState(this);
    }

    public void SwitchState(PlayerBaseState state)
    {
        
        currentState = state;
        state.EnterState(this);
    }
}
