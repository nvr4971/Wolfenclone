using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraLifePickup : MonoBehaviour
{
    public AudioSource pickupSound;
    public GameObject pickupText;

    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        GlobalLives.livesValue += 1;
        gameObject.SetActive(false);

        pickupText.SetActive(false);
        pickupText.GetComponent<Text>().text = "Extra Life!";
        pickupText.SetActive(true);
    }
}
