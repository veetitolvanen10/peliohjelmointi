using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
            (Mathf.Clamp(player.position.x, -0.78f, 1.01f), Mathf.Clamp(player.position.y, -9.6f, 12.8f), transform.position.z);
            
            
    }
}
