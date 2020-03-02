using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public GameObject particles;
    ScoreLogic addToScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void callScoreLogicScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        addToScore.addToScoreVoid();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) {

        spawnParticles(collision.transform.position);
        callScoreLogicScript();
        Destroy(collision.gameObject);
        
            }
    }

    void spawnParticles(Vector2 tempPosition)
    {
        Instantiate(particles, tempPosition, Quaternion.identity);
    }

}
