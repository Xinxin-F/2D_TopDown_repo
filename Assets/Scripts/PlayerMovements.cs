using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private Transform player;
     private Vector2 mousePos;

    private float dirX = 0f;
    private float dirY = 0f;
    [SerializeField] private float moveSpeed = 2.5f; //serializeField can change in unity Inspector window


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(dirX * moveSpeed, dirY * moveSpeed);
        if(!PausePage.isPaused){
            UpdateAnimationState();
            //rotateWithMouse(shootingAlignment);
        }
        
    }


    private void UpdateAnimationState()
    {

        // if (dirX > 0f)
        // {
        //     sprite.flipX = false; //avoid flipping tilemap
        // }
        // else if (dirX < 0f)
        // {
        //     sprite.flipX = true;
        // }
        // else
        // {

        // }



        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, 
            mousePos.x - transform.position.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.Euler(0, 0, angle);
    
 
    }

    //rotate with position
    // private void RotateWithMouse(){
    //     mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     float angle = Mathf.Atan2(mousePos.y - transform.position.y, 
    //         mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;
        
    //     transform.localRotation = Quaternion.Euler(0, 0, angle);
    // }

    // private void onCollisionEnter2D(Collision2D other){
        
    //     // for testing Lose Menu UI
    //     if(other.gameObject.CompareTag("Enemy")){
    //         LevelManager.manager.GameOver();
    //         Destroy(gameObject);
        
    //     }
    // }



    
}
