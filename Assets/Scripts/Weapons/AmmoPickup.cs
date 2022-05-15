using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject ammoPickup;
    public AudioSource ammoPickupSound;

    void OnCollisionEnter(Collision collision)
    {
        ammoPickup.SetActive(false);
        ammoPickupSound.Play();
        GlobalAmmoCount.currentAmmo += 40;
    }
}
