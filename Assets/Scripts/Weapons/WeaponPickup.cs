using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject weaponPickup;
    public GameObject weaponEquipped;
    public AudioSource pickupSound;

    void OnTriggerEnter(Collider other)
    {
        weaponEquipped.SetActive(true);
        weaponPickup.SetActive(false);
        pickupSound.Play();
    }
}
