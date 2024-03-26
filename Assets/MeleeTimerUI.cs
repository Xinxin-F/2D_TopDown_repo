using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MeleeTimerUI : MonoBehaviour
{
    [SerializeField] private Image uiFill;
    [SerializeField] private Text uiText;

    private void Start()
    {
        StartCooldown(0f);
    }

    public void StartCooldown(float cooldownTime)
    {
        StartCoroutine(UpdateTimer(cooldownTime));
        Debug.Log("StartCooldown method called with: " + cooldownTime);
    }

    private IEnumerator UpdateTimer(float cooldownTime)
    {
        float timeLeft = cooldownTime;
        uiFill.fillAmount = 1;

        while (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            uiFill.fillAmount = timeLeft / cooldownTime;
            uiText.text = $"{Mathf.Floor(timeLeft)}:{(timeLeft % 1).ToString("F1")}";
            yield return null;
        }

        uiFill.fillAmount = 0;
        uiText.text = "Ready";
    }
}




// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;


// public class MeleeTimerUI : MonoBehaviour
// {
//     [SerializeField] private Image uiFill;
//     [SerializeField] private Text uiText;
//     public int Duration;
//     public int remainingDuration;

//     private void Start(){
//         OnGoing(Duration);
//     }

//     private void OnGoing(int Second){
//         remainingDuration = Second;
//         StartCorountine();
//     }

//     private IEnumerator updateTimer(){
//         uiText.text = $"{remainingDuration / 60:00}: {remainingDuration % 60:00}";
//         remainingDuration--;
//         yield return new WaitForSeconds(1f);
//     }

    
// }
