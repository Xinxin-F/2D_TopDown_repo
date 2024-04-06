using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
   public UnityEvent OnScoreChanged;
   public int Score {get; private set;}
   public float GameTime { get; set; }
   


   public void AddScore(int amount){
        Score += amount;
        OnScoreChanged.Invoke();
      //   Debug.Log("ScoreAdded");
   }

   // private ScoreData sd;

   // void Awake(){
   //    sd = new ScoreData();
   // }

   // public IEnumerable<FinalScore> GetHighScores{
   //       return sd.finalScores.OrderByDescending(x => x.finalScore);
   // }

   // public void AddScoreToBoard(RankContent finalScore){
   //    sd.scores.Add(finalScore);
   // }



}
