using UnityEngine;

public class EnnemyMoveState : IState
{
    private int _increment = 0;
    
    public void Enter(EnnemyStateMachineData ennemyStateMachineData)
    {
        Debug.Log($"Enter {nameof(EnnemyMoveState)}");
        ennemyStateMachineData.shootBullet.IsShoot = false;
    }

    public IState Update(EnnemyStateMachineData ennemyStateMachineData)
    {
        IState nextState = null;
        
        ennemyStateMachineData.ennemyTransform.position =
            Vector2.Lerp(ennemyStateMachineData.ennemyTransform.position, ennemyStateMachineData.randomPosition[_increment], ennemyStateMachineData.speedMovement * Time.deltaTime);

        if (Vector2.Distance(ennemyStateMachineData.ennemyTransform.position, ennemyStateMachineData.randomPosition[_increment]) < .3f)
        {
            if (_increment+1 >= ennemyStateMachineData.randomPosition.Length)
            {
                _increment = 0;
            }
            else
            {
                _increment++;
            }
        }
        
        Vector2 direction = ((Vector3)ennemyStateMachineData.randomPosition[_increment] - ennemyStateMachineData.ennemyTransform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        ennemyStateMachineData.ennemyTransform.rotation = Quaternion.Lerp(ennemyStateMachineData.ennemyTransform.rotation, Quaternion.Euler(ennemyStateMachineData.ennemyTransform.forward * (angle - ennemyStateMachineData.rotationOffset)), Time.deltaTime * 1.5f);

        if (Vector2.Distance((Vector2)ennemyStateMachineData.ennemyTransform.position, (Vector2)ennemyStateMachineData.targetTransform.position) < ennemyStateMachineData.distanceDetectTarget)
        {
            nextState = new EnnemyAttackState();
        }

        return nextState;
    }

    public void Exit(EnnemyStateMachineData ennemyStateMachineData)
    {
        Debug.Log($"Exit {nameof(EnnemyMoveState)}");
    }
}
