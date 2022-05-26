using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldPickUp : MonoBehaviour
{
    public GameObject goldIngots;
    public AudioSource pickupSound;
    public GameObject pickupText;

    void OnTriggerEnter(Collider other)
    {
        GlobalScore.scoreValue += 300;

        goldIngots.SetActive(false);
        pickupSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;

        pickupText.SetActive(false);
        pickupText.GetComponent<Text>().text = "Picked up Stack of Gold Ingots";
        pickupText.SetActive(true);
    }
}
