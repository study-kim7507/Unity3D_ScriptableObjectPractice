using UnityEngine;

[CreateAssetMenu(fileName = "HealthBelowCondition", menuName = "Scriptable Objects/TankStateCondition/HealthBelowCondition")]
public class HealthBelowCondition : ConditionSO
{
    public float _threshold = 30.0f;

    public override bool CheckCondition(TankStateMachine owner)
    {
        return owner._currentHealth <= _threshold;
    }
}
