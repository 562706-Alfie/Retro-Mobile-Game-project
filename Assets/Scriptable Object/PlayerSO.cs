using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/PlayerSO")]

public class PlayerSO : ScriptableObject
{
    public Vector3 topRespawnLocation;
    public bool respawnTop;
    public Vector3 bottomRespawnLocation;
    public bool respawnBottom;
    public Vector3 currentRespawnPoint;
}
