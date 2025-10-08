using UnityEngine;

public class Missile : MonoBehaviour
{
    public float _missileAttackPower = 10.0f;
    public DamageCalculator _damageCalculator;

    private void OnCollisionEnter(Collision collision)
    {
        BaseTankUnit target = collision.gameObject.GetComponent<BaseTankUnit>();
        if (target != null)
        {
            float damage = _damageCalculator.CalculateDamage(_missileAttackPower, target._defensePower);
            target.TakeDamage(damage);
        }
        else
        {
            Debug.Log("¥ÎªÛ¿Ã ≈ ≈©∞° æ∆¥‘");
        }
        Destroy(gameObject);
    }
}
