using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void Play()
    {
        //levelSelect.SetActive(true);
        //mainMenu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
    }
    public void UnPauseButton()
    {
        Time.timeScale = 1.0f;
    }
    public void ExitLevel()
    {
        Time.timeScale = 1.0f;
    }
}
