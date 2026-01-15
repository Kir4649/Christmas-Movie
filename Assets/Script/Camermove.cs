using UnityEngine;

public class Camermove : MonoBehaviour
{
   private float speed = 5.0f;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            //transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
               
    }
}
