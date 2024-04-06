using System;
using UnityEngine;

[System.Serializable]
public class GameResult
{
    [SerializeField]
    public int Score { get; set; }

    [SerializeField]
    public DateTime GameTime { get; set; } 
}