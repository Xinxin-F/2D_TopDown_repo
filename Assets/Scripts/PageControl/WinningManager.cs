using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinningManager : TimerScript
{
    
    public void SwitchScene(string name){
        SceneManager.LoadScene(name);
    }
}

