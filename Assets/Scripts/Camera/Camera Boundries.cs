using UnityEngine;

public class CameraBoundries : MonoBehaviour
{
    public Transform player;

    private float topBounds = 5f;
    private float bottomBounds = -5f;

    void LateUpdate()
    {
        float clampedY = Mathf.Clamp(player.position.y, bottomBounds, topBounds); // Clamp ensures a value never goes above or below a threshold
        transform.position = new Vector3(0, clampedY, transform.position.z);
    }
}