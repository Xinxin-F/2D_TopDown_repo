using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class ScoreController : MonoBehaviour
{
   public UnityEvent OnScoreChanged;
   public int Score {get; private set;}
   public DateTime GameTime { get; set; }
   


   public void AddScore(int amount){
        Score += amount;
        OnScoreChanged.Invoke();
      //   Debug.Log("ScoreAdded");
   }

   // public void WinGame() {
   //    GameResult result = new GameResult();
   //    result.Score = Score;
   //    // Set other details on result...

   //    Ranking ranking = new Ranking();
   //    ranking.LoadFromFile("ranking");
   //    ranking.AddResult(result);
   //    ranking.SaveToFile("ranking");
   // }

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
