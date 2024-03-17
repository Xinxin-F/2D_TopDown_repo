using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(1, 10)] //limit the range for bullet speed
    [SerializeField] private float speed = 2f;

    [Range(1, 10)]
    [SerializeField] private float lifetime = 3f; //die after 3 seconds

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime); 
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed; //fly straight away

    }

    // destroy when hit enemy

    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    

}
