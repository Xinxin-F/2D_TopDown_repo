using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprawner : MonoBehaviour
{
    // [SerializeField] private int NumToSpawn;

    [System.Serializable]
    public class SpawnableObject
    {
        public GameObject prefab;
        public int spawnNumber;
    }
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
        int tries = 100;

        for (int i = 0; i < NumToSpawn; i++)
        {
            do
            {
                screenX = Random.Range(-0.4f, 20f);
                screenY = Random.Range(-9f, 10f);
                pos = new Vector2(screenX, screenY);
                tries--;
            } while (Physics2D.OverlapCircle(pos, objectToSpawn.transform.localScale.x) != null && tries > 0);

            if (tries > 0)
            {
                GameObject instance = Instantiate(objectToSpawn, pos, objectToSpawn.transform.rotation);
                // if (instance.GetComponent<Enemy>())
                // {
                //     instance.GetComponent<Enemy>().spawner = this;
                // }
            }
        }
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
}
