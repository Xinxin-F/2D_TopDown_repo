using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField] private float MeleeDamage = 2f;


    private float rangedAttackTimer;
    private float MeleeAttackTimer;
    //public MeleeTimerUI meleeTimerUI;
    
    //[SerializeField] Slider BulletSlider;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        //meleeTimerUI = GetComponentInChildren<MeleeTimerUI>(); // initialise timer 
    }

     void Update()
    {
        //rotateWithMouse(shootingAlignment);
        if(!PausePage.isPaused){
            ShootingRotateWithMouse();
            checkRangeAttack();
            checkMeleeAttack();
        }
        
        
    }

    // check whether range attack is triggered
    private void checkRangeAttack(){
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
        if(Input.GetMouseButtonDown(1) && MeleeAttackTimer <= 0f){
            anim.SetTrigger("MeleeAttack");
            MeleeAttackTimer = MeleeCool; //reset timer every time shoot

            // Start the cooldown timer UI
            ///meleeTimerUI.StartCooldown(MeleeCool);
        }
        else{
            MeleeAttackTimer -= Time.deltaTime;
        }

    }

    public float RemainingMeleeAttackPercentage{
        get{
            // Debug.Log(MeleeAttackTimer/MeleeCool);
            return MeleeAttackTimer/MeleeCool;
        }
    }

    private void ShootingRotateWithMouse(){
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - shootingAlignment.position.y, 
            mousePos.x - shootingAlignment.position.x) * Mathf.Rad2Deg - 90f;
        
        shootingAlignment.rotation = Quaternion.Euler(0, 0, angle);
    }

    // private void ShootingRotateWithMouse(){
    //     float angle = AngleTowardsMouse()
    // }


    private void RangedAttack(){
        Instantiate(bulletPrefab, shootingAlignment.position, shootingAlignment.rotation);
    }

    // private void MeleeAttack(){
    //     Instantiate(MeleePrefab, transform.position, transform.rotation);
    // }

    // player is not attacking enemy, it is actually bullet attack it.
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){
        //  if(other.gameObject.CompareTag("Enemy")){
            other.GetComponent<HealthController>().TakeDamage(MeleeDamage); //<> the name should be 
            // Debug.Log("Attack Enemy");
        }
        // else if (other.tag == "WrekableObs"){
        else if (other.CompareTag("WrekableObs")){
            other.GetComponent<WreckObsHealth>().TakeDamage(MeleeDamage);
            // Debug.Log("obstable Attack");

        }
    }


}
