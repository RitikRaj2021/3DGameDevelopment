using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private Vector3 _rotataion;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotataion * Time.deltaTime);
    }
}
