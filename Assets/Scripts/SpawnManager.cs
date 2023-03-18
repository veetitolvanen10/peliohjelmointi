using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 0.8f;
    private  EnemyAI enemyAi;
    
    private float spawnRadius = 12;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy());
        
        GameObject.Find("Enemy").GetComponent<EnemyAI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyAi.gameOver)
        StopCoroutine(spawnEnemy());
        
    }
    IEnumerator spawnEnemy()
    {
        Vector2 spawnPos = GameObject.Find("Player").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        int index = Random.Range(0, objectPrefabs.Length);
        Instantiate(objectPrefabs[index], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(spawnEnemy());
    }
}
