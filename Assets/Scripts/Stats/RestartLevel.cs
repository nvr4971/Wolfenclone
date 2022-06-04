using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public GameObject gameOver;

    void Start()
    {
        GlobalLives.livesValue -= 1;

        if (GlobalLives.livesValue == 0)
        {
            StartCoroutine(GameOver());
        }
        else
        {
            GlobalScore.scoreValue = PlayerPrefs.GetInt("ScoreSaved");
            GlobalAmmoCount.currentAmmo = PlayerPrefs.GetInt("AmmoSaved");

            SceneManager.LoadScene(GlobalComplete.currentFloor);
        }
    }
    
    IEnumerator GameOver()
    {
        gameOver.SetActive(true);

        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(0);
    }
}
