using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    public BallHandler BallFondler;
    public float Multiplier = 2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = BallFondler.transform.position;
        BallFondler.Multiply(Multiplier);
        Multiplier += (float)0.1;
    }
}
