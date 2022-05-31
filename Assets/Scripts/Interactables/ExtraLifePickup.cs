using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLifePickup : MonoBehaviour
{
    public AudioSource pickupSound;

    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        GlobalLives.livesValue += 1;
        gameObject.SetActive(false);
    }
}
