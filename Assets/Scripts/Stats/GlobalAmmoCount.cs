using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmoCount : MonoBehaviour
{
    public static int currentAmmo;
    public GameObject ammoCountUI;

    void Start()
    {
        currentAmmo = 0;
    }

    void Update()
    {
        ammoCountUI.GetComponent<Text>().text = "" + currentAmmo;    
    }
}
