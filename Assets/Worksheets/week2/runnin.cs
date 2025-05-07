using System;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class runnin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody PlayerRigidbody;
    public float speed = 10f;
    public float jumpForce = 5f;
    public Animator PlayerAnimator;

    private Vector2 moveInput;
    private bool isJumping = false;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y) * speed * Time.deltaTime;
        PlayerRigidbody.linearVelocity = new Vector3(move.x, PlayerRigidbody.linearVelocity.y, move.z);
        PlayerAnimator.SetFloat("Speed", PlayerRigidbody.linearVelocity.magnitude);

        //flip the player based on the direction of the x movement
        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        PlayerAnimator.SetFloat("Speed", moveInput.magnitude);
    }
    
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            
            PlayerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            PlayerAnimator.SetTrigger("Jump");
        }
    }
}
