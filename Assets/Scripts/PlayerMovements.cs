using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

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

        UpdateAnimationState();
        //rotateWithMouse(shootingAlignment);

        
    }


    private void UpdateAnimationState()
    {

        if (dirX > 0f)
        {
            sprite.flipX = false; //avoid flipping tilemap
        }
        else if (dirX < 0f)
        {
            sprite.flipX = true;
        }
        else
        {

        }
 
    }

    //rotate with position
    // private void RotateWithMouse(){
    //     mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     float angle = Mathf.Atan2(mousePos.y - transform.position.y, 
    //         mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;
        
    //     transform.localRotation = Quaternion.Euler(0, 0, angle);
    // }



    
}