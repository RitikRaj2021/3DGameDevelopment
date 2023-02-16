using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int goldValue = 1;

    public float pauseBeforePickup = .5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pauseBeforePickup > 0)
        {
            pauseBeforePickup -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && pauseBeforePickup <= 0)
        {
            LevelManagerScript.instance.AcquireGold(goldValue);

            Destroy(gameObject);

            //AudioManager.instance.PlaySFX(5);
        }
    }
}
