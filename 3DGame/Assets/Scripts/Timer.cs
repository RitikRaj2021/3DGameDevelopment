using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text Time_text;

    public int Duration;
    private int remainigDuration;


    // Start is called before the first frame update
    void Start()
    {
        Being(Duration);
    }

    private void Being(int Second)
    {
        remainigDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainigDuration >= 0)
        {
            Time_text.text = $"{remainigDuration / 60:00} : {remainigDuration % 60:00}";
            remainigDuration--;
            yield return new WaitForSeconds(1f);
        }
        OnEnd();
    }

    private void OnEnd()
    {
        SceneManager.LoadScene("TimeRanOut");
    }
}
