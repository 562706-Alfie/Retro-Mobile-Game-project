using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManagerSO gameManager;
    public PlayerSO playerData;
    public AudioManagerSO audioManager;

    public Camera cam = Camera.main;

    public GameObject mainMenu;
    public GameObject timerGameObject;
    public GameObject scoreGameObject;
    public GameObject pauseButton;

    public GameObject Group1;
    public GameObject Group2;
    public GameObject Group3;
    public GameObject Group4;
    public GameObject Group5;
    public GameObject Group6;

    private float timerAmount;
    [SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private float scoreAmount;
    [SerializeField] private TextMeshProUGUI score;

    void Awake()
    {
        CameraMainMenu(); // Everytime the game starts, ensures that the camera is centered on the main Menu
    }
    void Start()
    {
        audioManager.PlaySound(0);
    }

    void Update()
    {
        /*
        if (gameManager.isInMenu == true)
        {
            CameraMainMenu();
            cam.transform.position = new Vector3(0, 0, -10);
        }
        if (gameManager.isInMenu == false)
        {
            CameraGameplay();
        }
        */

        // Timer
        if (gameManager.isInMenu == false)
        {
            timerGameObject.SetActive(true);
            scoreGameObject.SetActive(true);
            pauseButton.SetActive(true); 
            timerAmount = timerAmount - Time.deltaTime;
            timer.text = "Time Left: " + Mathf.CeilToInt(timerAmount);
            score.text = "Score: " + (gameManager.crossingCount);
        }
        if (gameManager.isInMenu == true)
        {
            scoreGameObject.SetActive(false);
            timerGameObject.SetActive(false);
            pauseButton.SetActive(false);
            timerAmount = 180;
        }
    }
    public void CameraMainMenu()
    {
        gameManager.isInMenu = true;
        cam.transform.position = new Vector3(0, 0, -10);
        playerData.respawnTop = true;
        mainMenu.SetActive(true);
        Group1.SetActive(true);
        Group2.SetActive(false);
        Group3.SetActive(false);
        Group4.SetActive(false);
        Group5.SetActive(false);
        Group6.SetActive(false);
    }
    public void CameraGameplay()
    {
        gameManager.isInMenu = false;
        gameManager.crossingCount = 0;
    }
}
