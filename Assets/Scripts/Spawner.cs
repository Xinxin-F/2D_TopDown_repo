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


    public List<SpawnableObject> spawnPool;
    //public GameObject toSpawn;

    public GameObject Quad;


    void Start()
    {

        foreach (var spawnObject in spawnPool)
        {
            SpawnObjects(spawnObject.prefab, spawnObject.spawnNumber);
        }
        
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
                 //Debug.Log("Spawning enemy at position: " + pos);
                GameObject instance = Instantiate(objectToSpawn, pos, objectToSpawn.transform.rotation);
                // if (instance.CompareTag("Enemy"))
                // {   
                //     EnemyMovements enemyMovements = instance.GetComponent<EnemyMovements>();
                //     enemyMovements.target = GameObject.FindGameObjectWithTag("Player").transform;
                // }
                if (instance.CompareTag("Enemy"))
                {   
                    if(objectToSpawn.name.Equals("Enemy")) //MeleeEnemy should be replaced by the name of your melee enemy prefab
                    {
                        EnemyMovements enemyMovements = instance.GetComponent<EnemyMovements>();
                        enemyMovements.target = GameObject.FindGameObjectWithTag("Player").transform;
                    }
                    else if(objectToSpawn.name.Equals("RangeEnemy")) //RangeEnemy should be replaced by the name of your range enemy prefab
                    {
                        RangeEnemyMovements rangeEnemyMovements = instance.GetComponent<RangeEnemyMovements>();
                        rangeEnemyMovements.target = GameObject.FindGameObjectWithTag("Player").transform;
                    }
                }           
                
            }
            if (tries <= 0)
            {
                Debug.Log("Failed to spawn object: " + objectToSpawn.name);
            }
        }
    }

}
