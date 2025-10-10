using UnityEngine;

[CreateAssetMenu(fileName = "SearchStateSO", menuName = "Scriptable Objects/TankState/SearchStateSO")]
public class SearchStateSO : TankStateSO
{
    public float _rotationSpeed = 90.0f;

    public override void OnEnter(TankStateMachine owner)
    {
        Debug.Log($"{owner.name} Ž�� ���¿� �����߽��ϴ�.");
    }

    public override void OnUpdate(TankStateMachine owner)
    {
        owner.transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    public override void OnExit(TankStateMachine owner)
    {
        Debug.Log($"{owner.name} Ž�� ���¿��� ������ϴ�.");
    }
}
