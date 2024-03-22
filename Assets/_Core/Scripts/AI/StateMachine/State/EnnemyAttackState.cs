using UnityEngine;

public class EnnemyAttackState : IState
{
    public void Enter(EnnemyStateMachineData ennemyStateMachineData)
    {
        Debug.Log($"Enter {nameof(EnnemyAttackState)}");
        ennemyStateMachineData.shootBullet.IsShoot = true;
    }

    public IState Update(EnnemyStateMachineData ennemyStateMachineData)
    {
        IState nextState = null;
        
        Vector2 direction = (ennemyStateMachineData.targetTransform.position - ennemyStateMachineData.ennemyTransform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        ennemyStateMachineData.ennemyTransform.rotation = Quaternion.Euler(ennemyStateMachineData.ennemyTransform.forward * (angle - ennemyStateMachineData.rotationOffset));
        
        if (Vector2.Distance((Vector2)ennemyStateMachineData.ennemyTransform.position, (Vector2)ennemyStateMachineData.targetTransform.position) > ennemyStateMachineData.distanceDetectTarget)
        {
            nextState = new EnnemyMoveState();
        }

        return nextState;
    }

    public void Exit(EnnemyStateMachineData ennemyStateMachineData)
    {
        Debug.Log($"Exit {nameof(EnnemyAttackState)}");
    }
}
