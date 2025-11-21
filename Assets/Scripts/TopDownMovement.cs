using UnityEngine;
using UnityEngine.InputSystem;

/////////////// INFORMATION ///////////////
// The following components are needed: Player Input
[RequireComponent(typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
public class TopDownMovement : MonoBehaviour
{
    public float maxSpeed = 7;
    public bool controlEnabled { get; set; } = true; 
    private Vector2 moveInput;
    private Rigidbody2D rb;
    public Animator animator;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    private void Update()
    {
    }
    private void FixedUpdate()
    {
        if (controlEnabled)
        {
            rb.linearVelocity = moveInput.normalized * maxSpeed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
// Write code for walking animation here. (Suggestion: send your current
        //velocity into the Animator for both the x- and y-axis.)
        if (rb.linearVelocity.x != 0 || rb.linearVelocity.y != 0)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
// Handle Move-input
// This method can be triggered through the UnityEvent in PlayerInput
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>().normalized;
    }
}

