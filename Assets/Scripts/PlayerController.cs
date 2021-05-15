using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;
    
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJump;
    public int extraJumpValue;

    // Start is called before the first frame update
    void Start()
    {
    	extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() //Se llama una cantidad de segundos determinada
    {
    	isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

    	moveInput = Input.GetAxisRaw("Horizontal");
    	rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    	if(facingRight == false && moveInput > 0)
    	{
    		Flip();
    	} else if(facingRight == true && moveInput < 0)
    	{
    		Flip();
    	}
    }

    void Flip()
    {
    	facingRight = !facingRight;
    	Vector3 Scaler = transform.localScale;
    	Scaler.x *= -1;
    	transform.localScale = Scaler;
    }

    void Update()
    {
    	if(isGrounded == true)
    	{
    		extraJump = extraJumpValue;
    	}

    	if(Input.GetKeyDown(KeyCode.W) && extraJump > 0)
    	{
    		rb.velocity = Vector2.up * jumpForce;
    		extraJump--;
    	} else if (Input.GetKeyDown(KeyCode.W) && extraJump == 0 && isGrounded == true)
    	{
    		rb.velocity = Vector2.up * jumpForce;
    	}
    }
}
