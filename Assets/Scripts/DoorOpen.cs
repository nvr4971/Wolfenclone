using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject theDoor;
    public GameObject theOtherTrigger;
    public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        this.GetComponent<BoxCollider>().enabled = false;
        theOtherTrigger.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        doorFX.Play();
        this.GetComponent<BoxCollider>().enabled = true;
        theOtherTrigger.GetComponent<BoxCollider>().enabled = true;
        theDoor.GetComponent<Animator>().Play("DoorClose");
    }
}