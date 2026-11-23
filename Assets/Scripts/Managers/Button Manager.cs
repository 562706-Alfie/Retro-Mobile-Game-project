using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelect;
    public GameObject timerGameObject;

    public GameManagerSO GameManager;
    
    [SerializeField] private float timerAmount;
    [SerializeField] private TextMeshProUGUI timer;
    public void Play()
    {
        levelSelect.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Update()
    {
        if (GameManager.isInMenu == false)
        {
            timerGameObject.SetActive(true);
            timerAmount = timerAmount - Time.deltaTime;
            timer.text = "Time Left: " + Mathf.CeilToInt(timerAmount);
        }
        if (GameManager.isInMenu == true)
        {
            timerGameObject.SetActive(false);
            timerAmount = 60;
        }
    }
}
