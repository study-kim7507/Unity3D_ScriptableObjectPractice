using UnityEngine;

[CreateAssetMenu(fileName = "TankData", menuName = "Scriptable Objects/TankData")]
public class TankData : ScriptableObject
{
    public Material _tankMaterial;
    public float _firePower;
    public GameObject _projectilePrefab;
}
