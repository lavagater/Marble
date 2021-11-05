using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //only dies if the enemy is on a team
        Team team = collision.gameObject.GetComponent<Team>();
        if (team)
        {
            Destroy(gameObject);
        }
    }
}
