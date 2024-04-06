using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float FullHealth; 
    [SerializeField] private float currentHealth; 

    //[SerializeField] private int KillMeleeEnemyScore = 10;

    // public UnityEvent OnDied;
    // private EnemyScoreAllocator enemyScoreAllocator;

    public float RemainingHealthPercentage{
        get{
            return currentHealth/FullHealth;
        }
    }
    
    public UnityEvent OnHealthChanged;

    public void TakeDamage(float damage){

        currentHealth -= damage;
        OnHealthChanged.Invoke();
        

        if(currentHealth <= 0f){
            Destroy(gameObject);
            //Debug.Log("Enemy Died");
            //LevelManager.manager.IncreaseScore(KillMeleeEnemyScore);
            LevelManager.manager.GameOver();
            // EnemyScoreAllocator.AllocateScore();

            // OnDied.Invoke();
        }
    }

}