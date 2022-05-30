using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallHealthPickUp : MonoBehaviour
{
    public GameObject cannedFood;
    public AudioSource eatSound;
    public GameObject pickupText;

    void OnTriggerEnter(Collider other)
    {
        if (GlobalHealth.healthValue >= 91)
        {
            GlobalHealth.healthValue = 100;
        }
        else
        {
            GlobalHealth.healthValue += 10;
        }

        cannedFood.SetActive(false);
        eatSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;

        pickupText.SetActive(false);
        pickupText.GetComponent<Text>().text = "10 Health recovered";
        pickupText.SetActive(true);
    }
}
