using UnityEngine;

public class AmmoboiEnter : MonoBehaviour {

public Gunmanager gunManager;
    public Gun gun;

    private void OnTriggerEnter()
    {
        if (gun.BackupAmmo < gun.MaxAmmo)
        {
            gunManager.Refillammo();
            Debug.Log("Ammo is refilled and back at " + gun.Ammo + "!");
            Destroy(gameObject);
        }
       
    }

}
