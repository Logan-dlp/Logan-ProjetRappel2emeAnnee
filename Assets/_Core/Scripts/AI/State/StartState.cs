using UnityEngine;

public class StartState : IState
{
    public void Enter(TestStateMachineData testStateMachineData)
    {
        Debug.Log($"Enter {nameof(StartState)}");
    }

    public IState Update(TestStateMachineData testStateMachineData)
    {
        return new IdleState();
    }

    public void Exit(TestStateMachineData testStateMachineData)
    {
        Debug.Log($"Exit {nameof(StartState)}");
    }
}
