using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderForMovingStairs : MonoBehaviour
{
    [SerializeField] List<GameObject> checkpoint;
    [SerializeField] GameObject player;
    [SerializeField] float dead;
    [SerializeField] Vector3 vectorPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {


            //transform.position(-10.49833, 5.14, -0.7391891);
        }
        Debug.Log("collison");
    }
}
