using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public Rigidbody2D Projectile;
    public int Ammo;
    //number of shots per second
    public float RateOfFire = 10;
    public float ProjectileSpeed = 5;
    private float fireTimer = 0;
    void Update()
    {
        if (Ammo > 0)
        {
            fireTimer -= Time.deltaTime;
            while (fireTimer < 0 && Ammo > 0)
            {
                fireTimer += 1 / RateOfFire;

                Rigidbody2D bullet = Instantiate(Projectile, transform.position, new Quaternion());
                bullet.velocity = transform.rotation * new Vector3(0, ProjectileSpeed, 0);
                Ammo -= 1;
            }
        }
    }
}
