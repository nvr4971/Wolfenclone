using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public bool isFiring = false;
    public GameObject theEnemy;
    public AudioSource weaponFireSound;
    public float fireRate = 1.5f;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            hitTag = hit.transform.tag;
        }

        if (hitTag == "Player" && !isFiring)
        {
            StartCoroutine(EnemyFire());
        }

        if (hitTag != "Player")
        {
            theEnemy.GetComponent<Animator>().Play("EnemyIdle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        theEnemy.GetComponent<Animator>().Play("EnemyFirePistol", -1, 0);
        theEnemy.GetComponent<Animator>().Play("EnemyFirePistol");
        weaponFireSound.Play();
        lookingAtPlayer = true;

        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }
}
