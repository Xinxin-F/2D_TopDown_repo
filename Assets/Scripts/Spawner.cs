using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // [SerializeField] private int NumToSpawn;

    [System.Serializable]
    public class SpawnableObject
    {
        public GameObject prefab;
        public int spawnNumber;
    }

    //[SerializeField]public int MeleeEnemyNumber; 
    public List<SpawnableObject> spawnPool;
    //public GameObject toSpawn;

    public GameObject Quad;


    void Start()
    {

        foreach (var spawnObject in spawnPool)
        {
            SpawnObjects(spawnObject.prefab, spawnObject.spawnNumber);
        }
        // SpawnObjects();
        //
        // foreach (var spawnObject in spawnPool)
        // {
        //     for (int i = 0; i < spawnObject.spawnNumber; i++)
        //     {
        //         SpawnObjects(spawnObject.prefab, spawnObject.spawnNumber);
        //     }
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void SpawnObjects(GameObject objectToSpawn, int NumToSpawn)
    {
        float screenX, screenY;
        Vector2 pos;
        int tries = 10000;

        for (int i = 0; i < NumToSpawn; i++)
        {
            do
            {
                screenX = Random.Range(-0.5f, 20f);
                screenY = Random.Range(-9f, 10f);
                pos = new Vector2(screenX, screenY);
                tries--;
            } while (Physics2D.OverlapCircle(pos, objectToSpawn.transform.localScale.x/2) != null && tries > 0);

            if (tries > 0)
            {
                GameObject instance = Instantiate(objectToSpawn, pos, objectToSpawn.transform.rotation);
                if (instance.CompareTag("Enemy"))
                {   
                    EnemyMovements enemyMovements = instance.GetComponent<EnemyMovements>();
                    enemyMovements.target = GameObject.FindGameObjectWithTag("Player").transform;
                }
                    
                //     instance.GetComponent<HealthController>().spawner = this;
                //     MeleeEnemyNumber++;
                // }
            }
            if (tries <= 0)
            {
                Debug.Log("Failed to spawn object: " + objectToSpawn.name);
            }
        }
    }
    
    // respawn enemy
    // public IEnumerator Respawn(GameObject objectToRespawn)
    // {
    //     yield return new WaitForSeconds(2);
    //     SpawnObjects(objectToRespawn, 1);
    // }


}

    // public void SpawnObjects(objectToSpawn, int NumToSpawn){
    //     //int randomItem = 0;
    //     //GameObject toSpawn;
    //     //MeshCollider c = Quad.GetComponent<MeshCollider>();
    //     float screenX, screenY;

    //     // Vector2 minBounds = Walls.bounds.min;
    //     // Vector2 maxBounds = Walls.bounds.max;

    //     Vector2 pos;
    //     // Create a list to keep track of positions already used

    //      int tries = 100;
    //     //List<Vector2> usedPositions = new List<Vector2>();

    //     for(int i = 0; i < NumToSpawn; i++){
    //         //

    //         // screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
    //         // screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
    //         do
    //         {
    //         screenX = Random.Range(-0.4f, 20f);
    //         screenY = Random.Range(-9f, 10f);
    //         pos = new Vector2(screenX, screenY);

    //         tries--;
    //         //  } while (usedPositions.Contains(pos)); 
    //         } while (Physics2D.OverlapCircle(pos, toSpawn.transform.localScale.x) != null && tries > 0);

    //         if (tries > 0)
    //         {
    //            // Instantiate(objectToSpawn, pos, objectToSpawn.transform.rotation);
    //            GameObject instance = Instantiate(objectToSpawn, pos, objectToSpawn.transform.rotation);

    //             if (instance.GetComponent<Enemy>())
    //             {
    //                 instance.GetComponent<Enemy>().spawner = this;
    //             }
    //         }

    //         //usedPositions.Add(pos);

    //         // float randomX = Random.Range(minBounds.x, maxBounds.x);
    //         // float randomY = Random.Range(minBounds.y, maxBounds.y);

    //         // Vector2 spawnPosition = new Vector2(randomX, randomY);
        
        
    //     }
    // }

