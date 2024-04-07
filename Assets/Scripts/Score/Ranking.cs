using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class Ranking
{
    [SerializeField]
    private List<GameResult> results = new List<GameResult>();
    public List<GameResult> Results
    {
        get { return results; }
    }

    

    public void AddResult(GameResult result)
    {
        results.Add(result);
        results.Sort((x, y) => y.Score.CompareTo(x.Score)); // Sort results by score in descending order
    }

    public void SaveToFile(string filename)
    {
        // string json = JsonUtility.ToJson(this);
        // SaveSystem.Save(filename, json);

        string json = JsonUtility.ToJson(this);
        Debug.Log("Saving data: " + json);
        SaveSystem.Save(filename, json);
    }

    public void LoadFromFile(string filename)
    {
        string json = SaveSystem.Load(filename);
        if (json != null)
        {
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}