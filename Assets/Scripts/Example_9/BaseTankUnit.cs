using UnityEngine;

public class BaseTankUnit : MonoBehaviour
{
    [SerializeField]
    private float _maxHP = 25.0f;
    protected float _currentHP;

    public float _defensePower = 5.0f;

    public AttackPattern _currentAttackPattern;
    public Transform _firePoint;

    public TankDestroyedEvent OnTankDestroyed;

    private void Awake()
    {
        _currentHP = _maxHP;
    }

    public void TakeDamage(float damage)
    {
        _currentHP -= damage;
        Debug.Log($"이름 : {gameObject.name} / 데미지 : {damage} / HP : {_currentHP}/{_maxHP}");
        
        if (_currentHP <= 0.0f)
        {
            _currentHP = 0.0f;
            Debug.Log($"{gameObject.name}이(가) 파괴되었습니다!");

            if (OnTankDestroyed != null)
                OnTankDestroyed.Raise(this);

            Destroy(gameObject);
        }
    }

    protected void Attack()
    {
        if (_currentAttackPattern != null && _firePoint != null)
        {
            _currentAttackPattern.ExecuteAttack(_firePoint); 
        }
        else
        {
            Debug.LogWarning("공격 패턴 또는 firePoint가 할당되지 않았습니다");
        }
    }
}
