using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class FinalScoreManager : MonoBehaviour
{
    private List<int> finalScores = new List<int>();
    private int maxScores = 10; // maximum number of scores to keep track of

    void Awake()
    {
        // Load previously saved scores
        for (int i = 0; i < maxScores; i++)
        {
            if (PlayerPrefs.HasKey("Score" + i))
            {
                finalScores.Add(PlayerPrefs.GetInt("Score" + i));
            }
            else
            {
                break; // No more scores saved
            }
        }
    }

    public void AddFinalScore(int score)
    {
        // Add new score
        finalScores.Add(score);

        // Sort in descending order and keep only top 'maxScores' scores
        finalScores = finalScores.OrderByDescending(x => x).Take(maxScores).ToList();

        // Save updated scores
        for (int i = 0; i < finalScores.Count; i++)
        {
            PlayerPrefs.SetInt("Score" + i, finalScores[i]);
        }
    }

    public List<int> GetHighScores()
    {
        return new List<int>(finalScores);
    }
}