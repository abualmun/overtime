using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform spriteHolder;
    private float h, v;
    public float speed;

    public float jumpPower = 1f;
    private float jumpTimer;

    private bool jump, isJumping;
    public Vector2 startScreen;
    public Vector2 endScreen;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");


        isMoving = h != 0 || v != 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;

        }

    }

    private void FixedUpdate()
    {

        if (!isJumping && isMoving)
        {
            rb.velocity = new Vector2(h * speed, v * speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }





        if (jump) Jump();


    }

    void Jump()
    {
        if (!isJumping)
        {
            jumpTimer = Time.time;
            isJumping = true;
        }
        if (jumpTimer + jumpPower >= Time.time)
        {
            jump = false;
            isJumping = false;
        }


    }
}
