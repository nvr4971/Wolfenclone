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

        

        if (GlobalComplete.currentFloor + 1 > SceneManager.sceneCountInBuildSettings)
        {
            GlobalComplete.enemyCount = 0;
            GlobalComplete.treasureCount = 0;

            yield return new WaitForSeconds(10);

            SceneManager.LoadScene(0);
        }
        else
        {
            GlobalComplete.currentFloor += 1;

            PlayerPrefs.SetInt("SceneToLoad", GlobalComplete.currentFloor);
            PlayerPrefs.SetInt("LivesSaved", GlobalLives.livesValue);
            PlayerPrefs.SetInt("ScoreSaved", GlobalScore.scoreValue);
            PlayerPrefs.SetInt("AmmoSaved", GlobalAmmoCount.currentAmmo);

            GlobalComplete.enemyCount = 0;
            GlobalComplete.treasureCount = 0;

            yield return new WaitForSeconds(10);

            SceneManager.LoadScene(GlobalComplete.currentFloor);
        }

        
    }
}
