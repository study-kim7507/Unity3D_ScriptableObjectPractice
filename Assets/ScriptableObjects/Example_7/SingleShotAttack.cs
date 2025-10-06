using UnityEngine;

[CreateAssetMenu(fileName = "SingleShotAttack", menuName = "Scriptable Objects/SingleShotAttack")]
public class SingleShotAttack : AttackPattern
{   
    public override void ExecuteAttack(Transform firePoint)
    {
        GameObject projectile = Instantiate(_projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            rigidbody.linearVelocity = firePoint.forward * _projectileSpeed;
        }
    }
}
