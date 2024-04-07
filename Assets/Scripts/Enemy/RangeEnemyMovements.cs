using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RangeEnemyMovements : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    private float rotateSpeed = 5.0f;

    [SerializeField] private float displacementDist = 5f;

    void Start(){
      
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

    }

    void Update(){
        if (target != null) {
            //agent.SetDestination(target.position);
            rotateTowardsPlayer();
            MoveAway();
        }
    }
    void MoveAway(){
        // Vector3 normDir = (transform.position - target.position).normalized;
        Vector3 normDir = (target.position - transform.position).normalized;
        // normDir = Quaternion.AngleAxis(45, Vector3.up) * normDir;
        normDir = Quaternion.AngleAxis(45, Vector3.forward) * normDir;
        MoveTowards(transform.position - (normDir*displacementDist));

        // NavMeshPath path = new NavMeshPath();
        // if (agent.CalculatePath(pos, path)) {
        //     if (path.status == NavMeshPathStatus.PathComplete) {
        //         MoveTowards(pos);
        //     } else if (path.status == NavMeshPathStatus.PathPartial) {
        //         MoveTowards(path.corners[path.corners.Length - 1]);
        //     } // Consider handling PathInvalid status too.
        // }
        
    }

    void MoveTowards(Vector3 pos){
        agent.SetDestination(pos);
    }
    

    void rotateTowardsPlayer(){
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);
    }
}


    





    


