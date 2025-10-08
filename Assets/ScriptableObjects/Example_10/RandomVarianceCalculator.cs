using UnityEngine;

[CreateAssetMenu(fileName = "RandomVarianceCalculator", menuName = "Scriptable Objects/RandomVarianceCalculator")]
public class RandomVarianceCalculator : DamageCalculator
{
    public float _minMultiplier = 0.8f;
    public float _maxMultiplier = 1.2f;

    public override float CalculateDamage(float attackPower, float defensePower)
    {
        float baseDamage = Mathf.Max(attackPower - defensePower, 0.0f);
        float variance = Random.Range(_minMultiplier, _maxMultiplier);
        return baseDamage * variance;   
    }
}
