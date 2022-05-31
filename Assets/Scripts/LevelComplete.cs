using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

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
    }
}
