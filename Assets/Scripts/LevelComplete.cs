using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject levelTimer;

    void OnTriggerEnter(Collider other)
    {
        levelTimer.SetActive(false);
        StartCoroutine(CompleteFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompleteFloor()
    {
        fadeOut.SetActive(true);

        yield return new WaitForSeconds(2);

        completePanel.SetActive(true);

        yield return new WaitForSeconds(10);

        GlobalScore.scoreValue = 0;
        GlobalComplete.enemyCount = 0;
        GlobalComplete.treasureCount = 0;

        SceneManager.LoadScene(3);
    }
}
