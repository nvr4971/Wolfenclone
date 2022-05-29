using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyA : MonoBehaviour
{
    public GameObject keyUI;
    public GameObject lockedTrigger;
    public GameObject otherLockedTrigger;
    public GameObject theKey;

    void OnTriggerEnter(Collider other)
    {
        keyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        otherLockedTrigger.SetActive(true);

        GetComponent<BoxCollider>().enabled = false;
        theKey.SetActive(false);
    }
}
