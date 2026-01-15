using UnityEngine;

public class DoorMove : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        //Doorが衝突したオブジェクトがCamerだった場合
        if (collision.gameObject.CompareTag("Camer"))
        {
            
            //扉が１８０度回転する
            transform.Rotate(0, Time.deltaTime * 180, 0);
        }
    }
}
