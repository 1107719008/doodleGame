using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    bool gameHasEnded = false;

    //float restartDelay = 1f;
    
    public Text FinScore; 


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            GameOverCanvas.SetActive(true);

            gameHasEnded = true;
            //Invoke("Restart", restartDelay);

            FinScore.text = PlayerPrefs.GetInt("FinalScore",0).ToString();

        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
