using UnityEngine;

public class TankStateMachine : MonoBehaviour
{
    [HideInInspector]
    public float _currentHealth;
    [HideInInspector]
    public float _stateTimer;

    public TankStateSO _initialState;
    TankStateSO _currentState;

    public EnemyRegistrySO _enemyRegistry;

    private void Start()
    {
        ChangeState(_initialState);
    }

    private void Update()
    {
        _stateTimer += Time.deltaTime;
        _currentState.OnUpdate(this);

        foreach (var transition in _currentState._transitions)
        {
            if (transition._condition.CheckCondition(this))
            {
                ChangeState(transition._toState);
                break;
            }
        }
    }

    public void ChangeState(TankStateSO newState)
    {
        _currentState?.OnExit(this);
        _currentState = newState;
        _currentState.OnEnter(this);
        _stateTimer = 0.0f;
    }

    public float GetNearestEnemyDistance()
    {
        float distance = float.MaxValue;

        if (_enemyRegistry != null)
        {
            distance = _enemyRegistry.GetClosestEnemyDistance(gameObject);
        }

        return distance;
    }
}
