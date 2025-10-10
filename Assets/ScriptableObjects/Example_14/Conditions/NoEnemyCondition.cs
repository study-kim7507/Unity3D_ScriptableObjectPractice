using UnityEngine;

[CreateAssetMenu(fileName = "NoEnemyCondition", menuName = "Scriptable Objects/TankStateCondition/NoEnemyCondition")]
public class NoEnemyCondition : ConditionSO
{
    public float _detectRadius = 5.0f;

    public override bool CheckCondition(TankStateMachine owner)
    {
        return owner.GetNearestEnemyDistance() > _detectRadius;
    }
}
