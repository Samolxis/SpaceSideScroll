using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject projectile;
    public float speed = 1f;
    float width = 20.0f;
    float height =8.5f;
    float offset = 01f;
    

    void Start()
    {
        
    }

   void SpawnProjectile()
    {
        if (Input.GetKeyDown(KeyCode.K))
            Instantiate(projectile, new Vector3(transform.position.x+offset, transform.position.y, transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnProjectile();
        PlayerMovement();
    }
    
    void PlayerMovement() 
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y <= height)
            transform.Translate(0,speed,0);

        if (Input.GetKey(KeyCode.S) && transform.position.y >= -height)
            transform.Translate(0, -speed, 0);

        if (Input.GetKey(KeyCode.A) && transform.position.x >= -width)
            transform.Translate(-speed, 0, 0);

        if (Input.GetKey(KeyCode.D) && transform.position.x <= width)
            transform.Translate(speed, 0, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
