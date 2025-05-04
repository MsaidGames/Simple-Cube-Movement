using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject lvlCompleteUI;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("End Game");
            Invoke("Restart", restartDelay);
        }
    }

    public void GameWon()
    {
        lvlCompleteUI.SetActive(true);
        Debug.Log("Game Won");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
