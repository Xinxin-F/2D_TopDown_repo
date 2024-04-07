using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeBullet : MonoBehaviour
{
     [Range(1, 10)] //limit the range for bullet speed
    [SerializeField] private float speed = 2f;

    private Rigidbody2D rb;
    [SerializeField] private float RangeDamage = 1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed; //fly straight away
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.CompareTag("Player")){
            other.GetComponent<PlayerHealth>().TakeDamage(RangeDamage);
            Destroy(gameObject); //destroy itself once hit 
        }
        else {
            Destroy(gameObject);
        }
    }

}
