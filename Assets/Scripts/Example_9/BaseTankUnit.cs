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
        Debug.Log($"�̸� : {gameObject.name} / ������ : {damage} / HP : {_currentHP}/{_maxHP}");
        
        if (_currentHP <= 0.0f)
        {
            _currentHP = 0.0f;
            Debug.Log($"{gameObject.name}��(��) �ı��Ǿ����ϴ�!");

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
            Debug.LogWarning("���� ���� �Ǵ� firePoint�� �Ҵ���� �ʾҽ��ϴ�");
        }
    }
}
