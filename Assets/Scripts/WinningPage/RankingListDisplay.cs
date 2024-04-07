using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// using System.Collections.Generic;
// using UnityEngine;

public class RankingListDisplay : MonoBehaviour
{
    public RankingRowUI rankRowUIPrefab;

    void Start()
    {
        Ranking ranking = new Ranking();
        ranking.LoadFromFile("ranking");
        //Debug.Log();

        for (int i = 0; i < ranking.Results.Count; i++)
        {
            RankingRowUI row = Instantiate(rankRowUIPrefab, transform);
            row.SetRow(i + 1, ranking.Results[i].Score, ranking.Results[i].GameTime.ToString());
        }
    }
}


