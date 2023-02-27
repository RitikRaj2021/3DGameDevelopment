using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("L1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
