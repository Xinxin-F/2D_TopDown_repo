using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovements : MonoBehaviour
{
    // [SerializeField] Transform target;
    //public GameObject player;

    public Transform target;
    NavMeshAgent agent;
    private float rotateSpeed = 5.0f;

    void Start(){
      
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

    }

    void Update(){
        if (target != null) {
            agent.SetDestination(target.position);
            rotateTowardsPlayer();
        }
            // agent.SetDestination(target.position);
            // rotateTowardsPlayer();
        }
    

    void rotateTowardsPlayer(){
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);
    }
}

    // public GameObject player;
    // public Transform target;
    // public float EneSpeed = 2.5f;

    // private float distanceBet;
    // public float DistanceRange = 10;

    


    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(!target){
    //         getTarget();
    //     }
    //     else{
    //         moveTowardsTaget();

    //     }
    //     // distanceBet = Vector2.Distance(transform.position, player.transform.position);
    //     // Vector2 direction = player.transform.position - transform.position;

    //     // direction.Normalize();
    //     // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
    //     // if (distanceBet < DistanceRange){
    //         // // move towards player
    //         //transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, EneSpeed * Time.deltaTime);

    //         // transform.LookAt( player.transform.position, Vector2.up );
    //         // transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    //     // }

    // }

    // private void moveTowardsTaget(){

    //     transform.position = Vector2.MoveTowards(this.transform.position, 
    //     target.position, EneSpeed * Time.deltaTime);
    // }

    // private void getTarget(){
    //     if(GameObject.FindGameObjectWithTag("Player")){
    //         target = GameObject.FindGameObjectWithTag("Player").transform;
    //     }
        
    // }

    // use for non-trigger
    // private void onCollisionEnter2D(Collision2D other){
    //     if(other.gameObject.CompareTag("Bullet")){
    //         Destroy(other.gameObject);
    //         Destroy(gameObject);
    //     }
    // }

    //decrease health and died <= 0
    // public void TakeDamage(float damage){
    //     health -= damage;

    //     if(health <= 0f){
    //         Destroy(gameObject);
    //         Debug.Log("Enemy Died");
    //     }

    // private void onCollisionEnter2D(Collision2D other){
        
    //     // for testing Lose Menu UI
    //     if(other.gameObject.CompareTag("Player")){
    //         LevelManager.manager.GameOver();
    //         Destroy(other.gameObject);


    //     }
    // }

    





    

