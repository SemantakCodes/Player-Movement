using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {

    }
    public override void UpdateState(PlayerStateManager player)
    {
        Debug.Log("Jump");
        if (!player.jumpAction.IsPressed())
        {
            player.SwitchState(player.idleState);
        }
    }
    
}
