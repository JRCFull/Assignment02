using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManScript : MonoBehaviour
{
    public GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame


    public void Resume()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }
    public void backButton()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;

    }

    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void settings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
