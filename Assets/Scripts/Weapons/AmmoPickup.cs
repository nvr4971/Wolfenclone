using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickup : MonoBehaviour
{
    public GameObject ammoPickup;
    public AudioSource ammoPickupSound;
    public GameObject pickupText;

    void OnTriggerEnter(Collider other)
    {
        ammoPickup.SetActive(false);
        ammoPickupSound.Play();
        GlobalAmmoCount.currentAmmo += 40;
        GetComponent<BoxCollider>().enabled = false;

        pickupText.SetActive(false);
        pickupText.GetComponent<Text>().text = "Picked up Ammo Pack";
        pickupText.SetActive(true);
    }
}
