using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/VehicleSO")]

public class VehicleSO : ScriptableObject
{
    public GameObject vehicle;
    public Vector2 speed;
    public bool directionLeft;
    public int amount;
    public bool isSpawned;
    //public Vector3 respawnLocation;
}
