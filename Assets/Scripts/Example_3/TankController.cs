using System.Collections;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public Transform _firePoint;
    public Renderer _topRenderer;
    public TankData _tankData;

    private void Start()
    {
        _topRenderer.material = _tankData._tankMaterial;

        StartCoroutine(FireProjectileAfterDelay(1.0f));
    }

    IEnumerator FireProjectileAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        GameObject projectile = Instantiate(_tankData._projectilePrefab, _firePoint.position, _firePoint.rotation);

        Rigidbody rigidBody = projectile.GetComponent<Rigidbody>();
        if (rigidBody != null )
        {
            rigidBody.AddForce(_firePoint.forward * _tankData._firePower, ForceMode.Impulse);
        }
    }
}
