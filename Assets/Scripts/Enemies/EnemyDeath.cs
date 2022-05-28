using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("EnemyDeath");
            enemyAI.SetActive(false);
            theEnemy.GetComponent<LookAtPlayer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            GlobalScore.scoreValue += 100;
        }
    }
}
