using UnityEngine;

[RequireComponent(typeof(ShootBullet))]
public class EnnemyStateMachine : MonoBehaviour
{
    [SerializeField] private float _speedMovement;
    [SerializeField] private float _distanceDetectTarget;

    [SerializeField] private float _rotationOffset;
    [SerializeField] private Vector2 _spaceMovementMin;
    [SerializeField] private Vector2 _spaceMovementMax;

    private IState _currentState;
    private Transform _target;
    private Vector2[] _randomPosition;
    private ShootBullet _shootBullet;
    
    private EnnemyStateMachineData _ennemyStateMachineData;
    
    private void Start()
    {
        _target = GameObject.FindAnyObjectByType<PlayerMovement>().transform;
        _shootBullet = GetComponent<ShootBullet>();
        
        _randomPosition = new Vector2[5];
        for (int i = 0; i < _randomPosition.Length; i++)
        {
            _randomPosition[i] = new Vector2(Random.Range(_spaceMovementMin.x, _spaceMovementMax.x),
                                                Random.Range(_spaceMovementMin.y, _spaceMovementMax.y));
        }
        
        _ennemyStateMachineData = new EnnemyStateMachineData()
        {
            shootBullet = _shootBullet,
            ennemyTransform = transform,
            speedMovement = _speedMovement,
            randomPosition = _randomPosition,
            
            targetTransform = _target,
            distanceDetectTarget = _distanceDetectTarget,
            
            rotationOffset = _rotationOffset,
        };
        
        TransitionTo(new EnnemyMoveState());
    }

    private void Update()
    {
        IState nextState = _currentState.Update(_ennemyStateMachineData);
        if (nextState != null)
        {
            TransitionTo(nextState);
        }
    }

    private void TransitionTo(IState nextState)
    {
        _currentState?.Exit(_ennemyStateMachineData);
        _currentState = nextState;
        _currentState.Enter(_ennemyStateMachineData);
    }
}
