using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 10f;

    public Camera fpsCam;
    public ParticleSystem flash;
    public float MaxAmmo = 10f;
    public float Ammo;
    public float BackupAmmo;

    public AudioClip FireSound;
    public AudioClip EmptySound;
    public AudioClip ReloadSound;

    public AudioSource GunSounds;





    void Update () {
        if (Input.GetKey("r"))
        {
            Ammo += BackupAmmo;
            GunSounds.clip = ReloadSound;

            if (Ammo > MaxAmmo)
            {
                BackupAmmo = Ammo - MaxAmmo;
                Ammo = MaxAmmo;
                GunSounds.Play();

            }
            else {
                BackupAmmo -= BackupAmmo;
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }

	}

    void Shoot()
    {
        if (Ammo >= 1)
        {
            Ammo -= 1f;
            Debug.Log(Ammo);
            flash.Play();
            GunSounds.clip = FireSound;
            GunSounds.Play();

        }
        else
        {
            Debug.Log("Out of ammo!");
            GunSounds.clip = EmptySound;
            GunSounds.Play();

        }

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && Ammo >= 1)
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
