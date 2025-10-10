using UnityEngine;

[CreateAssetMenu(fileName = "IdleStateSO", menuName = "Scriptable Objects/TankState/IdleStateSO")]
public class IdleStateSO : TankStateSO
{
    public override void OnEnter(TankStateMachine owner)
    {
        Debug.Log($"{owner.name} ��� ���¿� �����߽��ϴ�.");
    }

    public override void OnUpdate(TankStateMachine owner)
    {
        
    }

    public override void OnExit(TankStateMachine owner)
    {
        Debug.Log($"{owner.name} ��� ���¿��� ������ϴ�.");
    }
}
