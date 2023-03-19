using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAI : MonoBehaviour

{
    private Animator animator;
    public float speed;
    public Transform target;
    public bool gameOver;
    
    public float attackRange;
    private SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy follows assigned target until in attack range = execute attack
        if (Vector2.Distance(transform.position, target.position) > attackRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            animator.SetTrigger("Attack");
        }

        // Flip enemy sprite direction towards target
        if (transform.position.x < target.transform.position.x)
        {
            sprite.flipX = false;
        }
        else sprite.flipX = true;
    }
   
    //When enemy enters player collider, trigger game over and destroy player
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))


        {
            
            Destroy(Other.gameObject);
            Debug.Log("Game over!");
            gameOver = true;
        }
    }
}
