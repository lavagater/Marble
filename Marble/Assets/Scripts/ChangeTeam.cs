using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Team))]
public class ChangeTeam : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Team team = collision.gameObject.GetComponent<Team>();
        if (team)
        {
            Team myTeam = GetComponent<Team>();
            myTeam.SetTeam(team);
        }
    }
}
