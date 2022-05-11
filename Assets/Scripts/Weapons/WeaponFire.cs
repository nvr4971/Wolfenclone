using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public GameObject weapon;
    public GameObject muzzleFlash;
    public AudioSource weaponFire;
    public bool isFiring = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") & !isFiring)
        {
            StartCoroutine(FiringWeapon());
        }
    }

    IEnumerator FiringWeapon()
    {
        isFiring = true;
        weapon.GetComponent<Animator>().Play("M9Fire");
        muzzleFlash.SetActive(true);
        weaponFire.Play();

        yield return new WaitForSeconds(0.05f);

        muzzleFlash.SetActive(false);

        yield return new WaitForSeconds(0.25f);

        weapon.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
