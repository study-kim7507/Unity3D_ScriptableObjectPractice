using UnityEngine;

[CreateAssetMenu(fileName = "ElementData", menuName = "Scriptable Objects/ElementData")]
public class ElementData : ScriptableObject
{
    // 약점이 되는 다른 속성을 할당하기 위함.
    // FireElementData의 weakness에 WaterElementData를 할당하면, 
    // 불 속성은 물 속성에 약하다는 관계가 성립.
    public ElementData _weakness;

    public void CompareElementData(ElementData targetElementData)
    {
        if (targetElementData._weakness == this)
        {
            Debug.Log("ElementData : 탄환보다 내가 더 강함. 저항력이 반영됩니다.");
        }
        else if (targetElementData == this._weakness)
        {
            Debug.Log("ElementData : 탄환보다 내가 더 약함. 공격력이 증가합니다.");
        }
    }
}
