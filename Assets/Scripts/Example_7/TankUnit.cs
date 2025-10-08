using UnityEngine;

public class TankUnit : BaseTankUnit
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
}
