using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillAmmodisplay : MonoBehaviour {

    public Gun gun;
    public UnityEngine.UI.Text ammoText;

    void Update()
    {

        ammoText.text = "RefillAmmo: " + gun.BackupAmmo.ToString();



    }
}
