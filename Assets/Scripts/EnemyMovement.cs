using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveToTheLeft();
    }

    private void moveToTheLeft()
    {
        transform.Translate(-enemySpeed, 0, 0);
    }
}
