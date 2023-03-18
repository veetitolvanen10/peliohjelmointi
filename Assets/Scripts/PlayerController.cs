using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    private float verticalInput;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement, transform position can only be clamped values
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -17f, 17.37f), Mathf.Clamp(transform.position.y, -11.8f, 14.9f));

        if (horizontalInput < 0.0f)
            sprite.flipX = true;
        else
            sprite.flipX = false;
    }
}
