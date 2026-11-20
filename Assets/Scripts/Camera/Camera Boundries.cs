using UnityEngine;

public class CameraBoundries : MonoBehaviour
{
    public Transform player;
    public GameManagerSO gameManager;

    private float topBounds = 8f;
    private float bottomBounds = -8f;

    void LateUpdate()
    {
        if (gameManager.isInMenu == false)
        {
            float clampedY = Mathf.Clamp(player.position.y, bottomBounds, topBounds); // Clamp ensures a value never goes above or below a threshold
            transform.position = new Vector3(0, clampedY, transform.position.z);
        }
    }
}