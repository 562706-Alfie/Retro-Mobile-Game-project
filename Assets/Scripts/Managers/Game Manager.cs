using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManagerSO gameManager;
    public Camera cam = Camera.main;

    public GameObject mainMenu;
    void Awake()
    {
        CameraMainMenu(); // Everytime the game starts, ensures that the camera is centered on the main Menu
    }
    
    void Update()
    {
        if (gameManager.isInMenu == true)
        {
            CameraMainMenu();
            cam.transform.position = new Vector3(0, 0, -10);
        }
        if (gameManager.isInMenu == false)
        {
            CameraGameplay();
        }
    }
    public void CameraMainMenu()
    {
        gameManager.isInMenu = true;
        cam.transform.position = new Vector3(0, 0, -10);
        //mainMenu.SetActive(true); Constantly happens. Put this where the player returns to the menu
    }
    public void CameraGameplay()
    {
        gameManager.isInMenu = false;
    }
}
