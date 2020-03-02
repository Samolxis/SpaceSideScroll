using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        MoveToTheLeft();
    }

    private void MoveToTheLeft()
    {
        transform.Translate(-enemySpeed, 0, 0);
    }
}
