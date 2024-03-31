using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RankRowUI : MonoBehaviour
{
    public TextMeshProUGUI rank;
    public TextMeshProUGUI finalScore;

    public void SetRow(int rank, int finalScore)
    {
        this.rank.text = rank.ToString();
        this.finalScore.text = finalScore.ToString();
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


