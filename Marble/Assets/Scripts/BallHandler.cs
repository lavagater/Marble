using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public CannonShoot Cannon;
    public int Ammo = 1;
    public Vector3 reset;
    public void Multiply(float multiplier)
    {
        Ammo = (int)(Ammo*multiplier);
    }
    public void Add(float amount)
    {
        Ammo = (int)(Ammo+ amount);
    }
    
    public void Release()
    {
        if (Cannon)
            Cannon.Ammo += Ammo;
        Ammo = 1;
    }
}
