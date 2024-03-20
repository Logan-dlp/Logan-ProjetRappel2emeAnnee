using UnityEngine;

public class TestStateMachine : MonoBehaviour
{
    [SerializeField] private int _healthValue;
    
    private IState _currentState;
    private TestStateMachineData _testStateMachineData;
    
    private void Start()
    {
        _testStateMachineData = new TestStateMachineData()
        {
            healthValue = _healthValue,
        };
        
        TransitionTo(new StartState());
    }

    private void Update()
    {
        IState nextState = _currentState.Update(_testStateMachineData);
        if (nextState != null)
        {
            TransitionTo(nextState);
        }
    }

    private void TransitionTo(IState nextState)
    {
        _currentState?.Exit(_testStateMachineData);
        _currentState = nextState;
        _currentState.Enter(_testStateMachineData);
    }
}
