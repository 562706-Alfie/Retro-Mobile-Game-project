using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManagerSO gameManager;
    public Camera cam = Camera.main;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        CameraMainMenu();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (gameManager.isInMenu == true)
        {
            CameraMainMenu();
        }

        // If false(out of menu), teleport player to start
    }

    void CameraMainMenu()
    {
        gameManager.isInMenu = true;
        cam.transform.position = new Vector3(0, 0, -10);
    }
}
