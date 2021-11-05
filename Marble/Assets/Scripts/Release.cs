using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Release : MonoBehaviour
{
    public BallHandler BallFondler;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = BallFondler.transform.position;
        BallFondler.Release();
    }
}
