using UnityEngine;
public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Rigidbody2D rb;
    private bool isGrounded;
    private void Start() { rb = GetComponent<Rigidbody2D>(); }
    private void Update() { 
        isGrounded = Physics2D.Raycast(groundCheck.position, Vector2.down, 0.1f, groundLayer);
        if (Input.GetButtonDown("Jump") && isGrounded) Jump();
    }
    private void Jump() { rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); }
}