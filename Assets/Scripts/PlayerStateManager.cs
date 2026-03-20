using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerBaseState currentState;
    PlayerJumpState jumpState = new PlayerJumpState();
    PlayerSprintState sprintState = new PlayerSprintState();
    PlayerWalkState walkState = new PlayerWalkState();
    PlayerIdleState idleState = new PlayerIdleState();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
    }
    

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }
}
