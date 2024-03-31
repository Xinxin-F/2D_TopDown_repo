using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcknowledgeManager : MonoBehaviour
{
    public void ReturnHome(string name){
        SceneManager.LoadScene(name);
    }
}
