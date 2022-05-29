using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPickup : MonoBehaviour
{
    public GameObject weaponPickup;
    public GameObject weaponEquipped;
    public AudioSource pickupSound;
    public GameObject pickupText;
    public GameObject pistolIcon;

    void OnTriggerEnter(Collider other)
    {
        weaponEquipped.SetActive(true);
        weaponPickup.SetActive(false);
        pickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;

        pickupText.SetActive(false);
        pickupText.GetComponent<Text>().text = "Picked up Weapon";
        pickupText.SetActive(true);

        pistolIcon.SetActive(true);
    }
}
