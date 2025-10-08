using UnityEngine;
public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private float moveX;
    private void Start() { rb = GetComponent<Rigidbody2D>(); }
    private void Update() { 
        moveX = Input.GetAxis("Horizontal"); 
        if (Input.GetButtonDown("Jump")) Jump();
    }
    private void FixedUpdate() { rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y); }
    private void Jump() { rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); }
}