using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        
    }
    public override void UpdateState(PlayerStateManager player)
    {
        Debug.Log("Walk");
        if(player.move == Vector3.zero)
        {
            player.SwitchState(player.idleState);
        }
        if (player.jumpAction.IsPressed())
        {
            player.SwitchState(player.jumpState);
        }
    }
    
}
