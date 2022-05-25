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

    public int genHurt;
    public AudioSource[] hurtSound;
    public GameObject hurtEffect;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            hitTag = hit.transform.tag;
        }

        if (hitTag == "ThePlayer" && !isFiring)
        {
            StartCoroutine(EnemyFire());
        }

        if (hitTag != "ThePlayer")
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

        GlobalHealth.healthValue -= 5;

        hurtEffect.SetActive(true);

        yield return new WaitForSeconds(0.2f);

        hurtEffect.SetActive(false);

        genHurt = Random.Range(0, 3);
        hurtSound[genHurt].Play();

        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }
}
