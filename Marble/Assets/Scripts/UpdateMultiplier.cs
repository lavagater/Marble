using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMultiplier : MonoBehaviour
{
    public GameObject gayo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = gayo.GetComponent<Multiply>().Multiplier.ToString();
    }
}
