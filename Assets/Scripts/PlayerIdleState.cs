using System.Diagnostics;
using Unity;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Print("Idle State Entered");
    }
    public override void UpdateState(PlayerStateManager player)
    {
        
    }
    
}