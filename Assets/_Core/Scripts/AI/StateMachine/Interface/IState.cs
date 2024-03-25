public interface IState
{
    void Enter(EnnemyStateMachineData ennemyStateMachineData);

    IState Update(EnnemyStateMachineData ennemyStateMachineData);

    void Exit(EnnemyStateMachineData ennemyStateMachineData);
}
