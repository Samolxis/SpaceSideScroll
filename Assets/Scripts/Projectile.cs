using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Atack();
    }

    void Atack()
    {
        transform.Translate(projectSpeed, 0, 0);
    }

}
