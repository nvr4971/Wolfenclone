using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallLevel001 : MonoBehaviour
{
    public GameObject secretWall;

    void OnTriggerEnter(Collider other)
    {
        secretWall.GetComponent<Animator>().Play("Level001SecretWall");
        GetComponent<BoxCollider>().enabled = false;
    }
}
