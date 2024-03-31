using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MeleeTimerUI : MonoBehaviour
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
            uiFill.fillAmount = playerShoot.RemainingMeleeAttackPercentage;

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