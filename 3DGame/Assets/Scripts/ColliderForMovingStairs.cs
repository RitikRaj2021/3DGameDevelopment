using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderForMovingStairs : MonoBehaviour
{

    //[SerializeField] List<GameObject> checkpoint;
    //[SerializeField] GameObject player;
    //[SerializeField] float dead;
    //[SerializeField] Vector3 vectorPoint;

    // Start is called before the first frame update
    private Vector3 respawnPosition;

    private void Start()
    {
        // Set the initial respawn position to the object's current position
        respawnPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Set the player's position to the respawn point's position
            other.transform.position = respawnPosition;
        }
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger entered!");
            transform.Translate(new Vector3(37.48f, 5.14f, -0.7391891f));
            Debug.Log("Player moved!");
        }

    }*/
}
