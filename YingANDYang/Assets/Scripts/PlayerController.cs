using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool canJump;

    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if ((Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space)) && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        //flipping character
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            if (transform.localScale.x == 1 || transform.localScale.x == -1)
            {
                characterScale.x = -1;
            }
            if (transform.localScale.x == 2 || transform.localScale.x == -2)
            {
                characterScale.x = -2;
            }
            if (transform.localScale.x == 0.5 || transform.localScale.x == -0.5)
            {
                characterScale.x = (float)-0.5;
            }

        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (transform.localScale.x == 1 || transform.localScale.x == -1)
            {
                characterScale.x = 1;
            }
            if (transform.localScale.x == 2 || transform.localScale.x == -2)
            {
                characterScale.x = 2;
            }
            if (transform.localScale.x == 0.5 || transform.localScale.x == -0.5)
            {
                characterScale.x = (float)0.5;
            }
        }
        transform.localScale = characterScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        else
        {
            if (collision.gameObject.tag == "Wall")
            {

            }
            else
            {
                isGrounded = false;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
        else
        {
            if (collision.gameObject.tag == "Wall")
            {

            }
            else
            {
                isGrounded = false;
            }
        }
    }
}