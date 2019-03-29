using UnityEngine;


public class Gunmanager : MonoBehaviour {

    public Gun gun;

    public void Refillammo()
    {
        gun.BackupAmmo = gun.MaxAmmo;
        

    }

}
