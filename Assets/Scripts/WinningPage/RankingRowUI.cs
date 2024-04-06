using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RankingRowUI : MonoBehaviour
{
    public TextMeshProUGUI rankText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI dateTimeText;

    public void SetRow(int rank, int score, string dateTime)
    {
        rankText.text = rank.ToString();
        scoreText.text = score.ToString();
        dateTimeText.text = dateTime;
    }
}



//     void Start()
//     {
//         var rankScores = scoreController.GetHighScores().ToArray();
//         for(int i = 0; i < rankScores.Length; i++){
//             var row = Instantiate (rankRowUI, transform).GetComponent<RankRowUI>();
//             row.rank.text = (i+1).ToString();
//             row.finalScore.text = rankScores[i].finalScore.ToString();

//         }
//     }

//}


