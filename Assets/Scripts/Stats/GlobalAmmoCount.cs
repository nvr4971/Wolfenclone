using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmoCount : MonoBehaviour
{
    public static int currentAmmo = 0;
    public GameObject ammoCountUI;

    void Update()
    {
        ammoCountUI.GetComponent<Text>().text = "" + currentAmmo;    
    }
}
