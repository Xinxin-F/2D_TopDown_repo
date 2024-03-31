using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangeTimerUI : MonoBehaviour
{
    [SerializeField] private Image uiFill;
    [SerializeField] private Text readyText;
    public PlayerShoot playerShoot;

    void Start()
    {
        uiFill.fillAmount = 0f;
    }

    void Update()
    {
        UpdateCooldownRing();
    }

    public void UpdateCooldownRing()
    {
        if (playerShoot)
        {
            uiFill.fillAmount = playerShoot.RemainingRangeAttackPercentage;

            // display Ready Text
            if (uiFill.fillAmount == 0f)
            {
                readyText.text = "READY";
            }
            else
            {
                readyText.text = "";
            }
        }
    }
}
