using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;
    private float distanceBet;
    public float DistanceRange = 10;



    [SerializeField] private float MeleeCool = 1f;
    [SerializeField] private float MeleeAttackDamage = 1f;

    private float MeleeAttackTimer;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

     void Update()
    {
        checkMeleeAttack();
    }


    // check whether melee attack is triggered
    private void checkMeleeAttack(){

        distanceBet = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        if (distanceBet < DistanceRange && MeleeAttackTimer <= 0f){
            anim.SetTrigger("EnemyMelee");
            MeleeAttackTimer = MeleeCool; //reset timer every time shoot
        }
        else{
            MeleeAttackTimer -= Time.deltaTime;
        }

    }

    // player is not attacking enemy, it is actually bullet attack it.
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
        //  if(other.gameObject.CompareTag("Enemy")){
            other.GetComponent<PlayerHealth>().TakeDamage(MeleeAttackDamage); 
            // Debug.Log("Attack Enemy");
        }

    }

}
