using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckObsHealth : MonoBehaviour
{
    [SerializeField] private float FullHealth; 

    public void TakeDamage(float damage){

        FullHealth -= damage;

        if(FullHealth <= 0f){
            Destroy(gameObject);
        }
    }

}