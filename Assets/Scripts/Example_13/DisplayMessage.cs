using UnityEngine;

public class DisplayMessage : MonoBehaviour
{
    public void ShowDestroyedTank(BaseTankUnit destroyedTank)
    {
        if (destroyedTank != null)
        {
            Debug.Log($"�׽�Ʈ : {destroyedTank.gameObject.name}��(��) �ı��Ǿ����ϴ�!");
        }
    }
}
