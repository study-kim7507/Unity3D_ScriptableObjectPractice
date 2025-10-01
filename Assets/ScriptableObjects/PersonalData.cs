using UnityEngine;

[CreateAssetMenu(fileName = "PersonalData", menuName = "Scriptable Objects/PersonalData")]
public class PersonalData : ScriptableObject
{
    public string _myName;
    public int _myAge;
}
