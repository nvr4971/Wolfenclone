using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject ammoPickup;
    public AudioSource ammoPickupSound;

    void OnTriggerEnter(Collider other)
    {
        ammoPickup.SetActive(false);
        ammoPickupSound.Play();
        GlobalAmmoCount.currentAmmo += 40;
        GetComponent<BoxCollider>().enabled = false;
    }
}
