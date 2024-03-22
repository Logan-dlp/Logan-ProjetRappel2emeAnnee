using UnityEngine;

public class EnnemyStateMachineData
{
    public ShootBullet shootBullet;
    public Transform ennemyTransform;
    public float speedMovement;
    public Vector2[] randomPosition;

    public Transform targetTransform;
    public float distanceDetectTarget;

    public float rotationOffset;
}
