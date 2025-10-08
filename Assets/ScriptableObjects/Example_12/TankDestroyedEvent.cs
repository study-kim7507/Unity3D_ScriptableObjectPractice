using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankDestroyedEvent", menuName = "Scriptable Objects/TankDestroyedEvent")]
public class TankDestroyedEvent : ScriptableObject
{
    private readonly List<TankDestroyedEventListener> listeners
        = new List<TankDestroyedEventListener>();

    public void RegisterListener(TankDestroyedEventListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    public void UnregisterListener(TankDestroyedEventListener listener)
    {
        listeners.Remove(listener);
    }

    public void Raise(BaseTankUnit destroyedTank)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised(destroyedTank);
    }
}
