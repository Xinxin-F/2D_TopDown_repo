using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    private Vector2 mousePos;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootingAlignment;

    [SerializeField] private float RangedAttackCool = 0.5f;
    private float rangedAttrackTimer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
     void Update()
    {

        //rotateWithMouse(shootingAlignment);
        ShootingRotateWithMouse();

        // if left key is pressed, range attack
        if(Input.GetMouseButtonDown(0) && rangedAttrackTimer <= 0f){
            RangedAttack();
            rangedAttrackTimer = RangedAttackCool; //reset timer every time shoot
        }
        else{
            rangedAttrackTimer -= Time.deltaTime;
        }
        
    }

    private void ShootingRotateWithMouse(){
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - shootingAlignment.position.y, 
            mousePos.x - shootingAlignment.position.x) * Mathf.Rad2Deg - 90f;
        
        shootingAlignment.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void RangedAttack(){
        Instantiate(bulletPrefab, shootingAlignment.position, shootingAlignment.rotation);
    }


}
