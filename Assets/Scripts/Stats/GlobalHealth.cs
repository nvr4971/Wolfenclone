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
    }
}
