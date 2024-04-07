using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthController : MonoBehaviour
{
    [SerializeField] private float FullHealth;
    [SerializeField] private float CurrentHealth;

    [SerializeField] private int KillMeleeEnemyScore = 10;
    public Spawner spawner;



    void Start(){
        CurrentHealth = FullHealth;
        spawner = FindObjectOfType<Spawner>();
    }
    
    public void TakeDamage(float damage){
        CurrentHealth -= damage;

        if (CurrentHealth <= 0f)  
        {  
            GameObject objectToRespawn = gameObject;
            // Destroy(gameObject);
            LevelManager.manager.IncreaseScore(KillMeleeEnemyScore);

            if (spawner != null)
            {
                StartCoroutine(RespawnEnemy(objectToRespawn));
            }
        }   
    }

    IEnumerator RespawnEnemy(GameObject objectToRespawn)
    {
        //Destroy(gameObject);
        yield return new WaitForSeconds(2);
        spawner.SpawnObjects(objectToRespawn, 1);
        Destroy(gameObject);
    }
    
}

    // public void TakeDamage(float damage){

    //     CurrentHealth -= damage;

    //     if (CurrentHealth <= 0f)  
    //     {  
    //         if(FullHealth <= 0f){
    //         GameObject objectToRespawn = gameObject;
    //         Destroy(gameObject);
    //         LevelManager.manager.IncreaseScore(KillMeleeEnemyScore);

    //         if (spawner != null)
    //         {
    //             WaitForSeconds(2); 
    //             spawner.GetComponent<SpawnObjects>(objectToRespawn, 1);
    //         }
    //     }
        
    //     }

    // }

    

        // if(FullHealth <= 0f){
        //     Destroy(gameObject);
        //     //Debug.Log("Enemy Died");
        //     LevelManager.manager.IncreaseScore(KillMeleeEnemyScore);
        //     // EnemyScoreAllocator.AllocateScore();

        //     // OnDied.Invoke();
        //     // If the spawner exists, call Respawn
        // if (spawner != null)
        // {
        //     spawner.MeleeEnemyNumber--; 
        //     StartCoroutine(spawner.Respawn(gameObject));
        // }
        // }

        // if(CurrentHealth <= 0f){
        // GameObject objectToRespawn = gameObject;  // Save a reference to the current game object
        // Destroy(gameObject);
        // LevelManager.manager.IncreaseScore(KillMeleeEnemyScore);

        // // spawner.GetComponent<Respawn>.EnemyIsDied = true;

        // // if (spawner != null)
        // //     {
        // //         spawner.EnemyIsDied = true;
        // //         StartCoroutine(spawner.Respawn(objectToRespawn));
        // //     }

        //     if(spawner != null)
        //         {
        //             spawner.EnemyIsDied = true;
        //             StartCoroutine(spawner.Respawn(gameObject));
        //         }
        //         else
        //         {
        //             Debug.Log("Spawner is not assigned in HealthController");
        //         }

        //     // if (spawner != null)
        //     // {
        //     //     // spawner.MeleeEnemyNumber--; 
        //     //     // StartCoroutine(spawner.Respawn(objectToRespawn));
        //     //     spawner.GetComponent<Spawner>.someoneIsDead = true;
        //     // }
        // }


