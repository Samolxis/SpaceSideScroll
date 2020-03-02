using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public float spawnSpeed = 1f;
    readonly bool isSpawning = true;
    public GameObject enemyObj;
    float rng;
    void Start()
    {
        StartCoroutine(EnemyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemyTimer()
    {
        while (isSpawning == true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnSpeed);
        }
    }
 
    void SpawnEnemy()
    {
        rng = UnityEngine.Random.Range(-8, 8);
        Instantiate(enemyObj,new Vector3(25,rng,0), Quaternion.identity);
    }
}
