using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance = 0;
    [SerializeField] float speed = 0;
    [SerializeField] float jumpHeight = 0;
    [SerializeField] LayerMask groundMask;
    [SerializeField] CharacterController _characterController;


    bool isGrounded = false;
    Vector3 velocity;
    Vector3 movement;
    float x = 0;
    float z = 0;
    float gravity = -9.8f;
    Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        movement = transform.right * x + transform.forward * z;

        _characterController.Move(movement * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        _characterController.Move(velocity * Time.deltaTime);

        if(Input.GetKey("w"))
        {
            _animator.SetBool("isMoving", true);
        }

        else if(!Input.GetKey("w"))
        {
            _animator.SetBool("isMoving", false);
        }
    }

}
