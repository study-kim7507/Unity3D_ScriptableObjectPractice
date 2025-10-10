using UnityEngine;

public abstract class TankStateSO : ScriptableObject
{
    public Transition[] _transitions;

    public abstract void OnEnter(TankStateMachine owner);
    public abstract void OnUpdate(TankStateMachine owner);
    public abstract void OnExit(TankStateMachine owner);
}
