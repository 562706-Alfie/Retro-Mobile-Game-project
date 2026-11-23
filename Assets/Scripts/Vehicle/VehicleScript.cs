using Unity.VisualScripting;
using UnityEngine;

public class VehicleScript : MonoBehaviour
{
    public VehicleSO carData;
    public LaneSO laneData;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0)
        {
            rb.linearVelocity = new Vector2(carData.speed.x, 0);
        }
        else
        {
            rb.linearVelocity = new Vector2(-carData.speed.x, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Teleport"))
        {
            transform.position = laneData.respawnLocation;
        }
    }
}