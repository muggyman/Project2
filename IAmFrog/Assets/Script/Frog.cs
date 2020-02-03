using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    Controls controls;

    public CharacterController charController;

    Rigidbody m_Rigidbody;
    float side_Speed = 10f;
    float forward_speed = 15f;

    Vector3 velocity;
    float gravity = -9.81f;
    public float jumpHeight = 5f;

    public Transform groundCheck;
    public float groundDistance = 0.5f;
    public LayerMask groundMask;

    bool isGrounded;

    Vector2 sideMove;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        velocity.y += gravity * Time.deltaTime;
        charController.Move(velocity * Time.deltaTime);

        //Vector2 sm = new Vector2(sideMove.x, 0) * Time.deltaTime;
        //transform.Translate(sm, Space.World);
    }

    void OnForward()
    {
        //m_Rigidbody.velocity = translate.forward * forward_speed;
        //transform.Translate(transform.forward * forward_speed);
    }

    void OnLeft()
    {
        m_Rigidbody.velocity = -transform.right * side_Speed;
    }

    void OnRight()
    {
        m_Rigidbody.velocity = transform.right * side_Speed;
    }

    void OnJump()
    {
        if(isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

}
