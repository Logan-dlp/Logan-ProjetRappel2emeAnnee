using UnityEngine;

public class IdleState : IState
{
    public void Enter(TestStateMachineData testStateMachineData)
    {
        Debug.Log($"Enter {nameof(IdleState)}");
    }

    public IState Update(TestStateMachineData testStateMachineData)
    {
        if (testStateMachineData.healthValue >= 0)
        {
            
        }
        
        return null;
    }

    public void Exit(TestStateMachineData testStateMachineData)
    {
        Debug.Log($"Exit {nameof(IdleState)}");
    }
}
