// 지금 우리는 FireElementData, WaterElementData, IronElementData 이렇게 세 가지 속성만 만들어서 사용 중.
// 만약, 기획자가 여기에 추가로 다른 속성, 예를 들어 EarthElementData 같은 걸 만들고 싶다면?
// 만약 Enum을 사용하고 있다면, 프로그래머한테 새로운 열거형 타입을 코드에 추가해달라고 해야함.
// 하지만 지금처럼 스크립터블 오브젝트를 사용하고 있으면, 그럴 필요 없이 유니티의 메뉴에서
// Assets -> Create -> Scriptable Objects -> ElementData를 선택해서 바로 새로운 속성 애셋을 만들어 사용하기만 하면 된다.
// 코드 변경 없이 원하는 타입의 속성을 마음대로 만들어서 사용할 수 있다는 것.
// 이게 바로 스크립터블 오브젝트를 열거형 대신 사용할 때 얻을 수 있는 가장 큰 이점.

using UnityEngine;

public class TrainingTarget : MonoBehaviour
{
    public ElementData _elementData;

    private void OnCollisionEnter(Collision collision)
    {
        BulletController bulletController = collision.gameObject.GetComponent<BulletController>();
        if (bulletController != null)
        {
            // 스크립터블 오브젝트는 인스턴스가 아니라 자산(asset) 자체를 참조하므로
            // 같은 타입이라도 다른 에셋이면 다른 객체로 취급됩니다.
            // 따라서 두 객체의 _elementData가 같은지 비교하면
            // 동일한 스크립터블 오브젝트를 참조하는지 확인할 수 있습니다.
            //if (bulletController._elementData == _elementData)
            //{
            //    Debug.Log("두 객체의 ElementData가 같습니다.");
            //}
            //else
            //{
            //    Debug.Log("두 객체의 ElementData가 다릅니다.");
            //}

            ElementData bulletElementData = bulletController._elementData;
            _elementData.CompareElementData(bulletElementData);
        }
    }
}
