public interface IState
{
    void Enter(TestStateMachineData testStateMachineData);

    IState Update(TestStateMachineData testStateMachineData);

    void Exit(TestStateMachineData testStateMachineData);
}
