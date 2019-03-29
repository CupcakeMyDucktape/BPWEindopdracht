using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammodisplay : MonoBehaviour {

    public Gun gun;
    public UnityEngine.UI.Text ammoText;

    void Update () {
       
        ammoText.text = "Ammo: " + gun.Ammo.ToString();
            //        scoreText.text = player.position.z.ToString("0");



    }
}
