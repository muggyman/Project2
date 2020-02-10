using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    Controls controls;

    public CharacterController charController;

    Rigidbody m_Rigidbody;
    float moveSpeed = 5f;

    Vector3 velocity;
    float gravity = -9.81f;
    public float jumpHeight = 5f;

    public Transform groundCheck;
    public float groundDistance = 0.5f;
    public LayerMask groundMask;

    bool isGrounded;

    Vector2 sideMove;

    public GameObject tongue;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();

        m_Rigidbody = GetComponent<Rigidbody>();

        tongue.SetActive(false);
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

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        charController.Move(move * moveSpeed * Time.deltaTime);
    }

    void OnJump()
    {
        if(isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    void OnTongue()
    {
        tongue.SetActive(true);
        StartCoroutine(TongueDeactivate());
    }

    IEnumerator TongueDeactivate()
    {
        yield return new WaitForSeconds(0.2f);
        tongue.SetActive(false);
    }

}
