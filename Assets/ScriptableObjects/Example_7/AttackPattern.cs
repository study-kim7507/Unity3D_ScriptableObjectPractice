using UnityEngine;

[CreateAssetMenu(fileName = "AttackPattern", menuName = "Scriptable Objects/AttackPattern")]
public abstract class AttackPattern : ScriptableObject
{
    public GameObject _projectilePrefab;
    public float _projectileSpeed = 10.0f;
    public abstract void ExecuteAttack(Transform firePoint);
}
