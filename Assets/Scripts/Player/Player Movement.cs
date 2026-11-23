using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   public Vector2 speed;
   public Rigidbody2D rb;

   public PlayerSO playerData;
   public GameManagerSO gameManager;

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

        // Detection for cars to decide when honking
        gameManager.isHonking =
            Physics2D.Raycast(transform.position, Vector2.left, 5f, LayerMask.GetMask("Vehicle")) ||
            Physics2D.Raycast(transform.position, Vector2.right, 5f, LayerMask.GetMask("Vehicle")); // Starting point, direction, distance, what layers the raycasts hit
           // Raycast might hit vehicle moving away, could add invisible 2d sprite which blocks the cast

        // Respawn
        if (transform.position.y > 11.10)
        {
            playerData.currentRespawnPoint = playerData.topRespawnLocation;
        }
        if (transform.position.y < -10.58)
        {
            playerData.currentRespawnPoint = playerData.bottomRespawnLocation;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Vehicle"))
        {
            print("Collided");
            transform.position = playerData.currentRespawnPoint;
        }
    }
}
