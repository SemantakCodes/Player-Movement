using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        
    }
    public override void UpdateState(PlayerStateManager player)
    {
        //PLayer Idle Animation

        Debug.Log("IDLEE");
        if(player.move != Vector3.zero)
        {
            player.SwitchState(player.walkState);
        }
        
        
    }
}
