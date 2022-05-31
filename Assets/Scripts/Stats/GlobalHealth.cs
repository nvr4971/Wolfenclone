using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public static int healthValue;
    public GameObject healthDisplay;
    public int internalHealth;

    public GameObject HP100;
    public GameObject HP75;
    public GameObject HP50;
    public GameObject HP25;

    void Start()
    {
        healthValue = 100;
    }

    void Update()
    {
        if (healthValue <= 0)
        {
            SceneManager.LoadScene(0);
        }

        internalHealth = healthValue;
        healthDisplay.GetComponent<Text>().text = "" + healthValue;

        if (healthValue > 75)
        {
            HP100.SetActive(true);
            HP75.SetActive(false);
            HP50.SetActive(false);
            HP25.SetActive(false);
        }

        if (healthValue <= 75 && healthValue > 50)
        {
            HP100.SetActive(false);
            HP75.SetActive(true);
            HP50.SetActive(false);
            HP25.SetActive(false);
        }

        if (healthValue <= 50 && healthValue > 25)
        {
            HP100.SetActive(true);
            HP75.SetActive(false);
            HP50.SetActive(true);
            HP25.SetActive(false);
        }

        if (healthValue <= 25)
        {
            HP100.SetActive(false);
            HP75.SetActive(false);
            HP50.SetActive(false);
            HP25.SetActive(true);
        }
    }
}
