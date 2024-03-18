using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float health = 2f;
    [SerializeField] private int KillMeleeEnemyScore = 10;

    public void TakeDamage(float damage){
        health -= damage;

        if(health <= 0f){
            Destroy(gameObject);
            //Debug.Log("Enemy Died");
            LevelManager.manager.IncreaseScore(KillMeleeEnemyScore); 
        }
    }
}