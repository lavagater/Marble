using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotation : MonoBehaviour
{
    //the angles the cannon will rotate between, keep these between -360 and 360
    public float MinAngle;
    public float MaxAngle;
    public float RateOfRotation = 30;
    //-1 or 1 and it determines whether the angle is increased or decreased
    private int direction = 1;

    private void Start()
    {
        //convert the angles to 0 to 360
        if (MinAngle < 0)
            MinAngle += 360;
        if (MaxAngle < 0)
            MaxAngle += 360;
        transform.eulerAngles = new Vector3(0, 0, MinAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //rotate
        float angle = transform.rotation.eulerAngles.z;
        angle += direction * RateOfRotation * Time.deltaTime;
        if (transform.rotation.eulerAngles.z < MaxAngle && angle > MaxAngle)
        {
            angle = MaxAngle;
            direction = -1;
        }
        if (transform.rotation.eulerAngles.z > MinAngle && angle < MinAngle)
        {
            angle = MinAngle;
            direction = 1;
        }
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
