using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript instance;
    public int currentGold;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //UIController.instance.CoinText.text = currentGold.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AcquireGold(int amount)
    {
        currentGold += amount;

        //UIController.instance.CoinText.text = currentGold.ToString();
    }

}
