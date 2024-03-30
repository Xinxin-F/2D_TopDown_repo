using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class RankContent : MonoBehaviour
{
    public string gameTime;
    public float finalScore;

    public RankContent(string gameTime, float finalScore){
        this.gameTime = gameTime;
        this.finalScore = finalScore;
    }

}
