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
    [SerializeField] private GameObject MeleePrefab;
    [SerializeField] private Transform shootingAlignment;

    [SerializeField] private float RangedAttackCool = 0.5f;
    [SerializeField] private float MeleeCool = 2f;

    private float rangedAttackTimer;
    private float MeleeAttackTimer;




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
        checkRangeAttack();
        // checkMeleeAttack();
        
    }

    // check whether range attack is triggered
    private void checkRangeAttack(){
        // if left key is pressed, range attack
        if(Input.GetMouseButtonDown(0) && rangedAttackTimer <= 0f){
            RangedAttack();
            rangedAttackTimer = RangedAttackCool; //reset timer every time shoot
        }
        else{
            rangedAttackTimer -= Time.deltaTime;
        }
    }

    // check whether melee attack is triggered
    private void checkMeleeAttack(){
        // if right key is pressed, melee attack
        if(Input.GetMouseButtonDown(1) && MeleeAttackTimer <= 0f){
            anim.SetTrigger("MeleeAttack");
            MeleeAttackTimer = MeleeCool; //reset timer every time shoot
        }
        else{
            MeleeAttackTimer -= Time.deltaTime;
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

    // private void MeleeAttack(){
    //     Instantiate(MeleePrefab, transform.position, transform.rotation);
    // }

    // player is not attacking enemy, it is actually bullet attack it.
    // private void OnTriggerEnter2D(Collider2D other){
    //     if(other.tag == "Enemy"){
    //     //  if(other.gameObject.CompareTag("Enemy")){
    //         // other.GetComponent<HealthController>().TakeDamage(RangeDamage); //<> the name should be 
    //         Debug.Log("Attack Enemy");
    //     }
    // }


}
