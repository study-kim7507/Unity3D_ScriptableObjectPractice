using UnityEngine;

[CreateAssetMenu(fileName = "ShotGunAttack", menuName = "Scriptable Objects/ShotGunAttack")]
public class ShotgunAttack : AttackPattern
{
    public int _pelletCount = 5;
    public float _spreadAngle = 15.0f;

    public override void ExecuteAttack(Transform firePoint)
    {
        for (int i = 0; i < _pelletCount; i++)
        {
            float angle = Random.Range(-_spreadAngle, _spreadAngle);
            Quaternion rotation = firePoint.rotation * Quaternion.Euler(0, angle, 0);
            
            GameObject projectile = Instantiate(_projectilePrefab, firePoint.position, firePoint.rotation);
            Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
            if (rigidbody != null )
            {
                rigidbody.linearVelocity = rotation * Vector3.forward * _projectileSpeed;
            }
        }
    }
}
