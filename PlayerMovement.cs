using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;
    public float input;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;
    public LayerMask groundLayer;
    private bool isGrounded;
    public Transform feetPosition;
    public float groundCheckCircle;
    public float jumpTime = 0.35f;
    public float jumpTimeCounter;
    private bool isJumping;
        
    [SerializeField] private AudioSource jumpSoundEffect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        if(input<0)
        {
            spriteRenderer.flipX = false;
        }
        else if (input>0){
            spriteRenderer.flipX = true;
        }

        isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, groundLayer);

        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            jumpSoundEffect.Play();
            jumpTimeCounter = jumpTime;
            playerRb.velocity = Vector2.up*jumpForce;
            isJumping = true;
        }

        if(Input.GetButton("Jump") && isJumping == true)
        {
            if(jumpTimeCounter>0)
            {
                playerRb.velocity = Vector2.up*jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            
            else
            {
                isJumping = false;
            }
        }

        if(Input.GetButtonUp("Jump")){
            
        }
    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2 (input*speed, playerRb.velocity.y);
    }
}
