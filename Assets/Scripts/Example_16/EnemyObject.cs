using UnityEngine;

[DisallowMultipleComponent]
public class EnemyObject : MonoBehaviour
{
    public EnemyRegistrySO _registry;

    public Transform _target;
    public float _moveDelay = 5.0f;
    public float _moveSpeed = 3.0f;

    private float _timer;
    private bool _isMoving;

    private void OnEnable()
    {
        if (_registry != null)
        {
            _registry.Register(this);
        }
    }

    private void Start()
    {
        _timer = 0.0f;
        _isMoving = false;
    }

    private void Update()
    {
        if (_target == null)
            return;

        if (!_isMoving)
        {
            _timer += Time.deltaTime;
            if (_timer >= _moveDelay)
            {
                _isMoving = true;
            }
        }
        else
        {
            Vector3 direction = (_target.position - transform.position).normalized;
            transform.position += direction * _moveSpeed * Time.deltaTime;
        }
    }

    private void OnDisable()
    {
        if (_registry != null)
        {
            _registry.Unregister(this);
        }
    }
}
