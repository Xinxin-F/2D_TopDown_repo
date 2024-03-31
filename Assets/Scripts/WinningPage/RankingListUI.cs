using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// using System.Collections.Generic;
// using UnityEngine;

public class ScoreBoardUI : MonoBehaviour
{
    public RankRowUI rankRowUIPrefab;
    public FinalScoreManager finalScoreManager;

    void Start()
    {
        List<int> scores = finalScoreManager.GetHighScores();
        for(int i = 0; i < scores.Count; i++)
        {
            RankRowUI row = Instantiate(rankRowUIPrefab, transform);
            row.SetRow(i + 1, scores[i]);
        }
    }
}


