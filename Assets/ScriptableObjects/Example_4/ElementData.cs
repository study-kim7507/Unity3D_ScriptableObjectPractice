using UnityEngine;

[CreateAssetMenu(fileName = "ElementData", menuName = "Scriptable Objects/ElementData")]
public class ElementData : ScriptableObject
{
    // ������ �Ǵ� �ٸ� �Ӽ��� �Ҵ��ϱ� ����.
    // FireElementData�� weakness�� WaterElementData�� �Ҵ��ϸ�, 
    // �� �Ӽ��� �� �Ӽ��� ���ϴٴ� ���谡 ����.
    public ElementData _weakness;

    public void CompareElementData(ElementData targetElementData)
    {
        if (targetElementData._weakness == this)
        {
            Debug.Log("ElementData : źȯ���� ���� �� ����. ���׷��� �ݿ��˴ϴ�.");
        }
        else if (targetElementData == this._weakness)
        {
            Debug.Log("ElementData : źȯ���� ���� �� ����. ���ݷ��� �����մϴ�.");
        }
    }
}
