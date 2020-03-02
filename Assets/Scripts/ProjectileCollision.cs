using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public GameObject particles;
    ScoreLogic addToScore;

    void CallScoreLogicScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        addToScore.AddToScoreVoid();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) {

        SpawnParticles(collision.transform.position);
        CallScoreLogicScript();
        Destroy(collision.gameObject);
        
            }
    }

    void SpawnParticles(Vector2 tempPosition)
    {
        Instantiate(particles, tempPosition, Quaternion.identity);
    }

}
