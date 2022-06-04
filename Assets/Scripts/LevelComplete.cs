using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject levelTimer;
    public GameObject levelEntities;
    public GameObject waitText;

    void OnTriggerEnter(Collider other)
    {
        levelTimer.SetActive(false);
        StartCoroutine(CompleteFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompleteFloor()
    {
        levelEntities.SetActive(false);

        fadeOut.SetActive(true);

        yield return new WaitForSeconds(2);

        completePanel.SetActive(true);

        GlobalComplete.currentFloor += 1;

        if (GlobalComplete.currentFloor >= SceneManager.sceneCountInBuildSettings)
        {
            waitText.GetComponent<Text>().text = "Returning to main menu...";

            yield return new WaitForSeconds(10);

            GlobalComplete.enemyCount = 0;
            GlobalComplete.treasureCount = 0;

            SceneManager.LoadScene(0);
        }
        else
        {
            waitText.GetComponent<Text>().text = "Loading next level...";

            PlayerPrefs.SetInt("SceneToLoad", GlobalComplete.currentFloor);
            PlayerPrefs.SetInt("LivesSaved", GlobalLives.livesValue);
            PlayerPrefs.SetInt("ScoreSaved", GlobalScore.scoreValue);
            PlayerPrefs.SetInt("AmmoSaved", GlobalAmmoCount.currentAmmo);

            yield return new WaitForSeconds(10);

            GlobalComplete.enemyCount = 0;
            GlobalComplete.treasureCount = 0;

            SceneManager.LoadScene(GlobalComplete.currentFloor);
        }

        
    }
}
