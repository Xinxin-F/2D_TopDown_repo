using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


// public enum GameState{
//     menu, 
//     inGame, 
//     gameOver
// }
public class LevelManager : MonoBehaviour
{
    public static LevelManager manager;

    public GameObject deatheScreen;

    public int score;
   // public TextMeshProUGUI scoreText;
    public SaveData data;
    public bool GameOverCheck;
    public Ranking ranking = new Ranking();

    private void Awake(){
        manager = this;
        SaveSystem.Initialise();
        ranking.LoadFromFile("ranking");
        GameOverCheck = false;
    }

    // activate deathscreen
    public void GameOver(){
       // TimerScript.instance.timeIsRunning = false; // Stop the timer
        Time.timeScale = 0f;
        deatheScreen.SetActive(true);
        GameOverCheck = true;
        
        
        //scoreText.text = "Score" + score.ToString(); //update when lose
    }

    // load the current game scene
    public void RestartGameButton(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }


    public void BackMenuButton(){
        SceneManager.LoadScene("MainMenu");
    }

    public void IncreaseScore(int amount){
        score += amount;
        GameObject.FindObjectOfType<ScoreUI>().UpdateScore(); //update in GameScene
    }

    [System.Serializable] public class SaveData{
    public int highscore;
    public SaveData(int _hs){
        highscore = _hs;
    }
    }

    // public void TransitSecondScene(){
    //     SceneManager.LoadScene("SecondMap");
    // }

    public void SaveScore()
    {
        GameResult result = new GameResult { Score = score, DateTime = System.DateTime.Now.ToString() };
        ranking.AddResult(result);
        ranking.SaveToFile("ranking");
    }



    // public GameState currentGameState = GameState.menu;
    // public static LevelManager manager;
    //   private void Awake(){
    //     manager = this;
    //     SaveSystem.Initialise();
    // }

    // void Start(){
    //     StartGame();
    // }

    // public void StartGame(){
    //     SetGameState(GameState.inGame);
    // }

    // public void GameOver(){
    //     SetGameState(GameState.gameOver);
    // }

    // public BackToMenu(){
    //     SetGameState(GameState.menu);
    // }

    // void SetGameState(GameState newGameState){
    //     if(newGameState == GameState.menu){

    //     }
    //     else if (newGameState == GameState.inGame){

    //     }
    //     else if (newGameState == GameState.gameOver){

    //     }
    //     currentGameState = newGameState;


    // }
}

