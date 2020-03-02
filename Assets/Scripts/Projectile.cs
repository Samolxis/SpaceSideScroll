using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectSpeed = 3f;
    void Update()
    {
         Atack();
    }

    void Atack()
    {
        transform.Translate(projectSpeed, 0, 0);
    }

}
