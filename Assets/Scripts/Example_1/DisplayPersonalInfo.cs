using UnityEngine;

public class DisplayPersonalInfo : MonoBehaviour
{
    public PersonalData _personalData;

    private void Start()
    {
        if (_personalData != null)
        {
            Debug.Log("�̸� : " + _personalData._myName);
            Debug.Log("���� : " + _personalData._myAge);
        }
        else
        {
            Debug.LogError("PersonalData�� �Ҵ���� �ʾҽ��ϴ�.");
        }
    }
}
