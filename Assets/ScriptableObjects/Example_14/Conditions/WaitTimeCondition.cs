using UnityEngine;

[CreateAssetMenu(fileName = "WaitTimeCondition", menuName = "Scriptable Objects/TankStateCondition/WaitTimeCondition")]
public class WaitTimeCondition : ConditionSO
{
    public float _waitTime = 2.0f;

    public override bool CheckCondition(TankStateMachine owner)
    {
        return owner._stateTimer >= _waitTime;
    }
}
