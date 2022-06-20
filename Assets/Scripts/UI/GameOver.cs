using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
    
}
