using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthController : MonoBehaviour
{
    [SerializeField] private float FullHealth; 

    [SerializeField] private int KillMeleeEnemyScore = 10;
    public Spawner spawner;

    // public UnityEvent OnDied;
    // private EnemyScoreAllocator enemyScoreAllocator;

    // public float RemainingHealthPercentage{
    //     get{
    //         return currentHealth/FullHealth;
    //     }
    // }

    public void TakeDamage(float damage){

        FullHealth -= damage;
        

        if(FullHealth <= 0f){
            Destroy(gameObject);
            //Debug.Log("Enemy Died");
            LevelManager.manager.IncreaseScore(KillMeleeEnemyScore);
            // EnemyScoreAllocator.AllocateScore();

            // OnDied.Invoke();
            // If the spawner exists, call Respawn
        // if (spawner != null)
        // {
        //     spawner.MeleeEnemyNumber--; 
        //     StartCoroutine(spawner.Respawn(gameObject));
        // }
        }


    }

}