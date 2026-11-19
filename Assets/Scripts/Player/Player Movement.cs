using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   public Vector2 speed;
   public Rigidbody2D rb;
   
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
        //test
    }
}
