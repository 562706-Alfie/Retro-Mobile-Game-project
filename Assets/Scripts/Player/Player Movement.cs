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

    [SerializeField] private float testCurrentSpeed;

    InputAction moveAction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //audioManager.PlayMusic();
        moveAction = InputSystem.actions.FindAction("Move");
    }
    void Update()
    {
        // Movement here
        if (gameManager.isInMenu == false)
        {
            Vector2 input = moveAction.ReadValue<Vector2>();
            input.x = 0;
            rb.linearVelocity = input * speed;
            testCurrentSpeed = rb.linearVelocity.magnitude;
        }

        // Detection for cars to decide when honking
        gameManager.isHonking =
            Physics2D.Raycast(transform.position, Vector2.left, 5f, LayerMask.GetMask("Vehicle")) ||
            Physics2D.Raycast(transform.position, Vector2.right, 5f, LayerMask.GetMask("Vehicle")); // Starting point, direction, distance, what layers the raycasts hit
           // Raycast might hit vehicle moving away, could add invisible 2d sprite which blocks the cast

        // Respawn and score
        if (transform.position.y > 11.10)
        {
            if (playerData.respawnTop == true)
            {
                gameManager.crossingCount++;
                playerData.respawnTop = false;
                playerData.respawnBottom = true;
            }
            playerData.currentRespawnPoint = playerData.topRespawnLocation;
        }
        if (transform.position.y < -10.58)
        {
            if (playerData.respawnBottom == true)
            {
                gameManager.crossingCount++;
                playerData.respawnTop = true;
                playerData.respawnBottom = false;
            }
            playerData.currentRespawnPoint = playerData.bottomRespawnLocation;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Vehicle"))
        {
            transform.position = playerData.currentRespawnPoint;
        }
    }
}
