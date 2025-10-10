using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyRegistrySO", menuName = "Scriptable Objects/EnemyRegistrySO")]
public class EnemyRegistrySO : ScriptableObject
{
    private readonly List<EnemyObject> _registeredEnemies = new List<EnemyObject>();   
    
    public void Register(EnemyObject enemy)
    {
        if (!_registeredEnemies.Contains(enemy))
        {
            _registeredEnemies.Add(enemy);
        }
    }

    public void Unregister(EnemyObject enemy)
    {
        if (_registeredEnemies.Contains(enemy))
        {
            _registeredEnemies.Remove(enemy);
        }
    }

    public float GetClosestEnemyDistance(GameObject origin)
    {
        float closest = float.MaxValue;
        Vector3 originPos = origin.transform.position;

        foreach (var enemy in _registeredEnemies)
        {
            float dist = Vector3.Distance(originPos, enemy.transform.position);
            if (dist < closest)
            {
                closest = dist;
            }
        }

        return closest;
    }
}
