using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Team : MonoBehaviour
{
    public int TeamLayer;
    public Color TeamColor;
    private void Start()
    {
        SetTeam(TeamLayer, TeamColor);
    }
    public void SetTeam(Team otherTeam)
    {
        SetTeam(otherTeam.TeamLayer, otherTeam.TeamColor);
    }
    public void SetTeam(int layer, Color color)
    {
        TeamLayer = layer;
        TeamColor = color;
        gameObject.layer = TeamLayer;
        gameObject.GetComponent<SpriteRenderer>().color = color;
    }
}
