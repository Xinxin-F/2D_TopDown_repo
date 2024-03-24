using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(1, 10)] //limit the range for bullet speed
    [SerializeField] private float speed = 2f;

    [Range(1, 10)]
    //[SerializeField] private float lifetime = 3f; //die after 3 seconds

    private Rigidbody2D rb;
    [SerializeField] private float RangeDamage = 1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Destroy(gameObject, lifetime); 
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed; //fly straight away
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.CompareTag("Enemy")){
            // Destroy(other.gameObject); //kill enemy in one bullet
            // Debug.Log("Attack Enemy");
            // LevelManager.manager.IncreaseScore(MeleeEnemyScore); 
            other.GetComponent<HealthController>().TakeDamage(RangeDamage);
            Destroy(gameObject); //destroy itself once hit 
        }
        else if (other.gameObject.CompareTag("Wall")){
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("WrekableObs")){
            other.GetComponent<WreckObsHealth>().TakeDamage(RangeDamage);
            Destroy(gameObject);
        }
    }


}
