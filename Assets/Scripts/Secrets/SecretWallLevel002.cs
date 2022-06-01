using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallLevel002 : MonoBehaviour
{
    public GameObject secretWall;

    void OnTriggerEnter(Collider other)
    {
        secretWall.GetComponent<Animator>().Play("Level002SecretWall");
        GetComponent<BoxCollider>().enabled = false;
    }
}
