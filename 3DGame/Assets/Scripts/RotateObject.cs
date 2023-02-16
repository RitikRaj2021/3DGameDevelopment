using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    float rotationSpeed = 60;
    Vector3 currentEulerAngles;
    float z;

    void Update()
    {
        currentEulerAngles += new Vector3(0, 0, z) * Time.deltaTime * rotationSpeed;

        transform.localEulerAngles = currentEulerAngles;
    }

    public void TurnX()
    {
        z = -1;
    }
    /*[SerializeField] private Vector3 _rotataion;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotataion * Time.deltaTime);
    }*/


}
