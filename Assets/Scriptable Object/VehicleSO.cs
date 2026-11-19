using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/VehicleSO")]

public class VehicleSO : ScriptableObject
{
    public GameObject vehicle;
    public Vector2 speed;
    public int amount;
    public bool isSpawned;
}
