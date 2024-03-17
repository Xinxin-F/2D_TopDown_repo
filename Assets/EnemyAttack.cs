using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    
    public GameObject player;
    public float EneSpeed = 2.5f;

    private float distanceBet;
    public float DistanceRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        distanceBet = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        // direction.Normalize();
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // if (distanceBet < DistanceRange){
            // // move towards player
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, EneSpeed * Time.deltaTime);

            // transform.LookAt( player.transform.position, Vector2.up );
            // transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        // }

    }

    
}
