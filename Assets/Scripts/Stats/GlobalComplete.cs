using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour
{
    public static int enemyCount;
    public GameObject enemyDisplay;

    public static int treasureCount;
    public GameObject treasureDisplay;

    public static int currentFloor = 3;

    void Update()
    {
        enemyDisplay.GetComponent<Text>().text = "" + enemyCount;
        treasureDisplay.GetComponent<Text>().text = "" + treasureCount;
    }
}
