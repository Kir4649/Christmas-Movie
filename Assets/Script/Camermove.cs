using System.Collections;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using static UnityEngine.GraphicsBuffer;

public class Camermove : MonoBehaviour
{
   private float speed = 1.0f;
   public Transform target;   // –Ú“I’n
    private bool Move = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {     
           Move = true;
            StartCoroutine(CamerMove());
        }
               
    }
    IEnumerator CamerMove()
    {
        while (Move)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
            yield return null;
        }
        
    }

    
}
