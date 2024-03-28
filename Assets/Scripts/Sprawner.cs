using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprawner : MonoBehaviour
{
    [SerializeField] private int NumToSpawn;
    public List<GameObject> spawnPool;
    //public GameObject toSpawn;

     public GameObject Quad;
    // public Collider Walls;


    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void SpawnObjects(){
        
        
    //     // GameObject toSpawn;
    //     for(int i = 0; i < NumToSpawn; i++){
    //         Instantiate(toSpawn, new Vector3(Random.Range(1f, 25), Random.Range(1f, 25), 0), toSpawn.transform.rotation);
    //     }

    // }


    public void SpawnObjects(){
        int randomItem = 0;
        GameObject toSpawn;
        //MeshCollider c = Quad.GetComponent<MeshCollider>();
        float screenX, screenY;

        // Vector2 minBounds = Walls.bounds.min;
        // Vector2 maxBounds = Walls.bounds.max;

        Vector2 pos;

        for(int i = 0; i < NumToSpawn; i++){
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            // screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            // screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            screenX = Random.Range(-2f, 18f);
            screenY = Random.Range(-13, 8);
            pos = new Vector2(screenX, screenY);

            // float randomX = Random.Range(minBounds.x, maxBounds.x);
            // float randomY = Random.Range(minBounds.y, maxBounds.y);

            // Vector2 spawnPosition = new Vector2(randomX, randomY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
        
    }

    // void PreventSpawnOverlap(){

    // }

//     private Vector2 GetRandomSpawnPosition(Collider2D collider, float obstacleClearanceRadius)
// {
//     Vector2 minBounds = collider.bounds.min;
//     Vector2 maxBounds = collider.bounds.max;

//     Vector2 spawnPosition = new Vector2(
//         Random.Range(minBounds.x, maxBounds.x),
//         Random.Range(minBounds.y, maxBounds.y)
//     );

//     Collider2D[] colliders = Physics2D.OverlapCircleAll(spawnPosition, obstacleClearanceRadius);
//     if (colliders.Length > 1)  // Assuming this script's collider is also detected
//     {
//         return GetRandomSpawnPosition(collider, obstacleClearanceRadius);
//     }

//     return spawnPosition;
// }

// public void SpawnObjects()
// {
//     int randomItem = 0;
//     GameObject toSpawn;
//     Collider2D collider = Quad.GetComponent<Collider2D>();

//     for (int i = 0; i < NumToSpawn; i++)
//     {
//         randomItem = Random.Range(0, spawnPool.Count);
//         toSpawn = spawnPool[randomItem];

//         Vector2 spawnPosition = GetRandomSpawnPosition(collider, obstacleClearanceRadius);
//         Instantiate(toSpawn, spawnPosition, Quaternion.identity);
//     }
// }
}
