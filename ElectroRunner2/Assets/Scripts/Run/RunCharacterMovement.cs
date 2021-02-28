using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCharacterMovement : MonoBehaviour
{
    public Animator animator;

    public float speed;
    public float jumpForce;
    public float downForce;

    private Rigidbody2D rb;

    bool isGrounded;
    bool up;

    public static bool END;
    public static bool isWon;
    public static bool isLost;

    public static float energy;

    public float energyrecovery;
    public float energylose;

    public Transform groundCheck;
    public Transform deathCheck;
    public float checkRadius;
    public float checkRadiusGround;

    public LayerMask whatIsGround;
    public LayerMask whatIsWin;
    public LayerMask whatIsLose;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isWon = false;
        isLost = false;
        END = false;
        up = false;
        energy = 100;
    }

    void Update()
    {
        if (isWon == true || isLost == true) END = true;

        if (isGrounded == true && energy < 100)
        {
            energy = energy + energyrecovery * Time.deltaTime; //refacere energie
        }

        if (Input.GetKey(KeyCode.Space) && energy > 0 && END == false)
        {
            transform.Translate(0f, jumpForce * Time.deltaTime, 0f); //scadere energie
            energy = energy - energylose * Time.deltaTime;
            up = true;
        }
        else up = false;

        if (END == false) transform.Translate(speed * Time.deltaTime, 0f, 0f);

        Debug.Log(energy);

        animator.SetBool("grounded", isGrounded);
        if (up == false && isGrounded == false) animator.SetBool("down", true);
        if (isWon == true) animator.SetBool("gg", true);
        if (isLost == true) animator.SetBool("dead", true);

    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadiusGround, whatIsGround);
        isWon = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsWin);
        isLost = Physics2D.OverlapCircle(deathCheck.position, checkRadius, whatIsLose);
    }
}
