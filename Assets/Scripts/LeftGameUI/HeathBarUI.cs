using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeathBarUI : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image heathForegroundImage;
    public void UpdateHealthBar(PlayerHealth playerHealth){
        heathForegroundImage.fillAmount = playerHealth.RemainingHealthPercentage;
    }
}
