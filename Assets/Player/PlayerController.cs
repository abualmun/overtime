using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform spriteHolder;
    private float h;
    public float speed;
    public float acceleration;
    public float jumpPower;
    public bool isGrounded;
    private bool isMoving;
    private bool jump;
    public float groundCheck;
    public float gravity = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isMoving = (Input.GetAxisRaw("Horizontal") != 0);
        jump = (isGrounded && Input.GetKey(KeyCode.UpArrow));
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, groundCheck);
        if (hit)
        {
            isGrounded = (hit.collider.tag == "Ground");
        }
        else
        {
            isGrounded = false;
        }

        if (!isGrounded) rb.drag = 0;


    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            h = Input.GetAxisRaw("Horizontal");
            if (Mathf.Abs(rb.velocity.x) <= speed)
            {
                Vector2 force = new Vector2(h * acceleration, 0);
                rb.AddForce(force);
            }

            rb.gravityScale = 9.8f * gravity;
            if (jump)
            {
                Jump();
            }
            if (rb.velocity.y <= 1) gravity = 1;
        }

    }

    void Jump()
    {
        gravity = 0;
        rb.gravityScale = 9.8f * gravity;
        Vector2 force = new Vector2(0, jumpPower);

        rb.AddForce(force);
        jump = false;
    }
}
