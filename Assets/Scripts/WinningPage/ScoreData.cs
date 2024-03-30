using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ScoreData : MonoBehaviour
{
    public List<RankContent> rankContent;
    public ScoreData(){
        scores = new List<RankContent>;
    }
}
