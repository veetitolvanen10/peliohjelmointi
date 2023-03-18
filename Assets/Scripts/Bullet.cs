using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.gameObject.CompareTag("Bullet"))


                {
            Destroy(gameObject);
            Destroy(Other.gameObject);
            Debug.Log("Trigger!");
        }
        
    }
     
}
