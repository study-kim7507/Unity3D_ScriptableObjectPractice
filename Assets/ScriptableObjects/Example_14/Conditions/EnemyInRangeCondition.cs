using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInRangeCondition", menuName = "Scriptable Objects/TankStateCondition/EnemyInRangeCondition")]
public class EnemyInRangeCondition : ConditionSO
{
    public float _detectRadius = 10.0f;

    public override bool CheckCondition(TankStateMachine owner)
    {
        return owner.GetNearestEnemyDistance() <= _detectRadius;
    }
}
