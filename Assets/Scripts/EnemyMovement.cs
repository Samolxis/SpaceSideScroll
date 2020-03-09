using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1f;
    bool changeSize = true;
    float rng;

   
    void Update()
    {
        StartCoroutine(size());
        MoveToTheLeft();
    }

    IEnumerator size()
    {
        rng = UnityEngine.Random.Range(2, 5);
        if (changeSize)
            transform.localScale = new Vector3(rng, rng, 0);
             changeSize = false;
            yield return new WaitForSeconds(0f);

    }


    private void MoveToTheLeft()
    {
        transform.Translate(-enemySpeed, 0, 0);
    }
}
