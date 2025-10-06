// ���� �츮�� FireElementData, WaterElementData, IronElementData �̷��� �� ���� �Ӽ��� ���� ��� ��.
// ����, ��ȹ�ڰ� ���⿡ �߰��� �ٸ� �Ӽ�, ���� ��� EarthElementData ���� �� ����� �ʹٸ�?
// ���� Enum�� ����ϰ� �ִٸ�, ���α׷������� ���ο� ������ Ÿ���� �ڵ忡 �߰��ش޶�� �ؾ���.
// ������ ����ó�� ��ũ���ͺ� ������Ʈ�� ����ϰ� ������, �׷� �ʿ� ���� ����Ƽ�� �޴�����
// Assets -> Create -> Scriptable Objects -> ElementData�� �����ؼ� �ٷ� ���ο� �Ӽ� �ּ��� ����� ����ϱ⸸ �ϸ� �ȴ�.
// �ڵ� ���� ���� ���ϴ� Ÿ���� �Ӽ��� ������� ���� ����� �� �ִٴ� ��.
// �̰� �ٷ� ��ũ���ͺ� ������Ʈ�� ������ ��� ����� �� ���� �� �ִ� ���� ū ����.

using UnityEngine;

public class TrainingTarget : MonoBehaviour
{
    public ElementData _elementData;

    private void OnCollisionEnter(Collision collision)
    {
        BulletController bulletController = collision.gameObject.GetComponent<BulletController>();
        if (bulletController != null)
        {
            // ��ũ���ͺ� ������Ʈ�� �ν��Ͻ��� �ƴ϶� �ڻ�(asset) ��ü�� �����ϹǷ�
            // ���� Ÿ���̶� �ٸ� �����̸� �ٸ� ��ü�� ��޵˴ϴ�.
            // ���� �� ��ü�� _elementData�� ������ ���ϸ�
            // ������ ��ũ���ͺ� ������Ʈ�� �����ϴ��� Ȯ���� �� �ֽ��ϴ�.
            //if (bulletController._elementData == _elementData)
            //{
            //    Debug.Log("�� ��ü�� ElementData�� �����ϴ�.");
            //}
            //else
            //{
            //    Debug.Log("�� ��ü�� ElementData�� �ٸ��ϴ�.");
            //}

            ElementData bulletElementData = bulletController._elementData;
            _elementData.CompareElementData(bulletElementData);
        }
    }
}
