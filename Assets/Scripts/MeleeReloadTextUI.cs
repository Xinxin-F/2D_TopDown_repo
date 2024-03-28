// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class MeleeReloadTextUI : MonoBehaviour
// {

//     private TMP_Text MeleeReloadText;
//     private PlayerShoot playerShoot;

//     private void Awake(){
//         MeleeReloadText = GetComponent<TMP_Text>();
//         playerShoot = FindObjectOfType<PlayerShoot>(); 
//     }
//     public void UpdateScore(){
//         MeleeReloadText.text = $"Melee Reload: {PlayerShoot.MeleeAttackTimer}";
//     }

// }