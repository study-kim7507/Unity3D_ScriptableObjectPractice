using UnityEngine;

public class BulletController : MonoBehaviour
{
    public ElementData _elementData;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
