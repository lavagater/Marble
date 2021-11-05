using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareGrid : MonoBehaviour
{
    public int Width = 100;
    public int Height = 100;
    public float CellWidth = 1;
    public float CellHeight = 1;
    public GameObject GridPrefabRed;
    public GameObject GridPrefabBlue;
    public GameObject GridPrefabYellow;
    public GameObject GridPrefabGreen;

    private void Start()
    {
        for (int i = 0; i < Height / 2; ++i)
        {
            for (int j = 0; j < Width / 2; ++j)
            {
                GameObject cellObject = Instantiate(GridPrefabYellow, new Vector3(i*CellWidth, j*CellWidth, 0), new Quaternion());
                cellObject.transform.parent = gameObject.transform;
            }

            for (int j = Width / 2; j < Width; ++j)
            {
                GameObject cellObject = Instantiate(GridPrefabRed, new Vector3(i*CellWidth, j*CellWidth, 0), new Quaternion());
                cellObject.transform.parent = gameObject.transform;
            }
        }

        for (int i = Height / 2; i < Height; ++i)
        {
            for (int j = 0; j < Width / 2; ++j)
            {
                GameObject cellObject = Instantiate(GridPrefabGreen, new Vector3(i*CellWidth, j*CellWidth, 0), new Quaternion());
                cellObject.transform.parent = gameObject.transform;
            }

            for (int j = Width / 2; j < Width; ++j)
            {
                GameObject cellObject = Instantiate(GridPrefabBlue, new Vector3(i*CellWidth, j*CellWidth, 0), new Quaternion());
                cellObject.transform.parent = gameObject.transform;
            }
        }
    }
}
