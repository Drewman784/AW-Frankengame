using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sizeChangeSpeed = 0.1f;
    private Rigidbody2D rb;
    public float jump;

    //Jump Check code from here: https://pastebin.com/Nk4xeupU
    [SerializeField] private bool canJump;
    [SerializeField] private bool isGrounded;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float checkRadius;
    [SerializeField] private LayerMask WhatIsGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
    }

    void Update()
    {
        //move right
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && CheckIfGrounded() && canJump)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            StartCoroutine(JumpCoolDown());
        }

            // Size Increase
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += new Vector3(sizeChangeSpeed, sizeChangeSpeed, 0);
        }

        // Size Decrease
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale -= new Vector3(sizeChangeSpeed, sizeChangeSpeed, 0);
        }
    }
    private bool CheckIfGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, WhatIsGround);
        return isGrounded;
    }
    IEnumerator JumpCoolDown()
    {
        canJump = false;
        yield return new WaitForSeconds(1.0f);
        canJump = true;
    }
}
