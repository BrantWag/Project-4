using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    public int jumpCount = 3;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float jumpHeight;
    public AudioClip JumpSound;
    public AudioClip Falling;
    private AudioSource audioSource;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJumped;
    private void Start()
    {

    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if (rb.position.y == 0f && rb.position.x == 0f)
        {
            GetComponent<Animator>().Play("Idle");
        }
    }
    void Update()
    {
        
        audioSource = GetComponent<AudioSource>();
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        if (grounded)
            doubleJumped = false;
        

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpHeight);
            GetComponent<Animator>().Play("jump");
            audioSource.PlayOneShot(JumpSound);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded) 
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpHeight);
            audioSource.PlayOneShot(JumpSound);
            doubleJumped = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2D.velocity = new Vector2(-moveSpeed, rb2D.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().Play("walk anim");
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2D.velocity = new Vector2(moveSpeed, rb2D.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().Play("walk anim");
        }


    }


}
