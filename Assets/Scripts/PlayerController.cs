using UnityEngine;
public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private float moveX;
    private void Start() { rb = GetComponent<Rigidbody2D>(); }
    private void Update() { moveX = Input.GetAxis("Horizontal"); }
    private void FixedUpdate() { rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y); }
}