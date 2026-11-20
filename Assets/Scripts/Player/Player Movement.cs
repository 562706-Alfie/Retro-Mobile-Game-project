using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   public Vector2 speed;
   public Rigidbody2D rb;
   public PlayerSO playerData;

   InputAction moveAction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        // Movement here
        Vector2 input = moveAction.ReadValue<Vector2>();
        rb.linearVelocity = input * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Vehicle"))
        {
            print("Collided");
            transform.position = playerData.bottomRespawnLocation;
        }
    }
}
