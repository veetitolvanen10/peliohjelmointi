using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public float moveSpeed = 10f;

    public Rigidbody2D rb;
    public Camera cam;
    Vector2 mousePos;
    Vector2 movement;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");
         


            
            
    }
     void FixedUpdate()
     {

        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);



        Vector2 lookDir = mousePos - rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;

     }

}
