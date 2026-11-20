using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/LaneSO")]

public class LaneSO : ScriptableObject
{
    public VehicleSO vehicle;
    public int amount;
    public Vector3 respawnLocation;

}
