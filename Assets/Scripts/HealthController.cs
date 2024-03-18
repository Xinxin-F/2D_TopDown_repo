using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float FullHealth; 

    [SerializeField] private int KillMeleeEnemyScore = 10;

    // public UnityEvent OnDied;
    // private EnemyScoreAllocator enemyScoreAllocator;

    public void TakeDamage(float damage){
        FullHealth -= damage;

        if(FullHealth <= 0f){
            Destroy(gameObject);
            //Debug.Log("Enemy Died");
            LevelManager.manager.IncreaseScore(KillMeleeEnemyScore);
            // EnemyScoreAllocator.AllocateScore();

            // OnDied.Invoke();
        }
    }




}