using UnityEngine;

public class DisplayPersonalInfo : MonoBehaviour
{
    public PersonalData _personalData;

    private void Start()
    {
        if (_personalData != null)
        {
            Debug.Log("이름 : " + _personalData._myName);
            Debug.Log("나이 : " + _personalData._myAge);
        }
        else
        {
            Debug.LogError("PersonalData가 할당되지 않았습니다.");
        }
    }
}
