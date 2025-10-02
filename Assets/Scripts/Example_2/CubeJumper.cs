using UnityEngine;

public class CubeJumper : MonoBehaviour
{
    public JumpData _jumpData;
    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        if (_rigidBody == null)
        {
            Debug.LogError("RigidBody를 찾을 수 없습니다");
            return;
        }
        InvokeRepeating("Jump", 0.0f, 3.0f);
    }

    private void Jump()
    {
        if (_jumpData != null && _rigidBody != null)
        {
            _rigidBody.AddForce(Vector3.up * _jumpData._jumpPower, ForceMode.Impulse);
        }
    }
}
