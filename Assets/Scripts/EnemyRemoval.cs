﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRemoval : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
          
            Destroy(collision.gameObject);

        }
    }


}
