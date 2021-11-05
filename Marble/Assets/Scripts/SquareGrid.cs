using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareGrid : MonoBehaviour
{
    public int Width = 100;
    public int Height = 100;
    public float CellWidth = 1;
    public float CellHeight = 1;
    public GameObject GridPrefab;

    private void Start()
    {
        for (int i = 0; i < Width; ++i)
        {
            for (int j = 0; j < Height; ++j)
            {
                GameObject cellObject = Instantiate(GridPrefab, new Vector3(i*CellWidth, j*CellWidth, 0), new Quaternion());
                cellObject.transform.parent = gameObject.transform;
            }
        }
    }
}
