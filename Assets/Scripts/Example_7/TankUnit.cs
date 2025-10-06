using UnityEngine;

public class TankUnit : MonoBehaviour
{
    public AttackPattern _currentAttackPattern;
    public Transform firePoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    private void Attack()
    {
        if (_currentAttackPattern != null && firePoint != null)
        {
            _currentAttackPattern.ExecuteAttack(firePoint);
        }
        else
        {
            Debug.LogWarning("공격 패턴 또는 firePoint가 할당되지 않았습니다!");
        }
    }
}
