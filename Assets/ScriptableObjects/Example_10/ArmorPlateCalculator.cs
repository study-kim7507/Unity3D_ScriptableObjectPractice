using UnityEngine;

[CreateAssetMenu(fileName = "ArmorPlateCalculator", menuName = "Scriptable Objects/ArmorPlateCalculator")]
public class ArmorPlateCalculator : DamageCalculator
{
    public override float CalculateDamage(float attackPower, float defensePower)
    {
        return attackPower * (100.0f / (100.0f + defensePower));
    }
}
