using UnityEngine;

[CreateAssetMenu(fileName = "FleeStateSO", menuName = "Scriptable Objects/TankState/FleeStateSO")]
public class FleeStateSO : TankStateSO
{
    public float _fleeRadius = 15.0f;
    public float _moveSpeed = 8.0f;
    public float _reachThreshold = 0.5f;

    private Vector3 _fleeTarget;

    public override void OnEnter(TankStateMachine owner)
    {
        SetNewFleeTarget(owner);
        Debug.Log($"{owner.name} 도망 상태에 진입했습니다.");
    }

    public override void OnUpdate(TankStateMachine owner)
    {
        Vector3 direction = (_fleeTarget - owner.transform.position).normalized;
        owner.transform.position += direction * _moveSpeed * Time.deltaTime;

        if (direction != Vector3.zero)
        {
            owner.transform.rotation = Quaternion.Slerp(owner.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * 5.0f);
        }

        float distance = Vector3.Distance(owner.transform.position, _fleeTarget);
        if (distance <= _reachThreshold)
        {
            SetNewFleeTarget(owner);
        }
    }

    public override void OnExit(TankStateMachine owner)
    {
        Debug.Log($"{owner.name} 도망 상태에서 벗어났습니다.");
    }

    private void SetNewFleeTarget(TankStateMachine owner)
    {
        Vector2 randomPoint = Random.insideUnitSphere * _fleeRadius;
        _fleeTarget = owner.transform.position + new Vector3(randomPoint.x, 0.0f, randomPoint.y);
    }
}
