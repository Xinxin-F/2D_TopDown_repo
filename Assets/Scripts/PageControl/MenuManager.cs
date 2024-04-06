using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void ChangeScene(string name){
       Time.timeScale = 1f;
        SceneManager.LoadScene(name);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
