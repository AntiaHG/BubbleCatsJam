using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static Health instance;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public int hearts = 5;
    private bool gameOver;

    void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true){
            return;
        }
    }
    public void HeartSystem(){
        hearts -= 1;

        if(hearts == 4){
            heart5.SetActive(false);
        }
        if(hearts == 3){
            heart4.SetActive(false);
        }
        if(hearts == 2){
            heart3.SetActive(false);
        }
        if(hearts == 1){
            heart2.SetActive(false);
        }
        if(hearts == 0){
            heart1.SetActive(false);
            SceneManager.LoadScene("GameOver");
            gameOver = true;
        }
    }
    public bool IsGameOver() {
        return gameOver;
    }
}
