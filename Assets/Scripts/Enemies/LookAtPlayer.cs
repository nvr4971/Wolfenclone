using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform thePlayer;

    void Update()
    {
        this.transform.LookAt(thePlayer);
    }
}
