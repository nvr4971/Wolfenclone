using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullHealthPickUp : MonoBehaviour
{
    public GameObject cannedFood;
    public AudioSource eatSound;
    public GameObject pickupText;

    void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 100;

        cannedFood.SetActive(false);
        eatSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;

        pickupText.SetActive(false);
        pickupText.GetComponent<Text>().text = "Full Health recovered";
        pickupText.SetActive(true);
    }
}
