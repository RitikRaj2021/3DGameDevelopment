using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private Vector3 _speed;

    void Update()
    {
        transform.Rotate(Vector3.Scale(_rotation, _speed) * Time.deltaTime);
    }
}
