using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public static float speed = 12f;
    public float gravity = -9.81f; //коэфициент гравитации
    public static float jumpHeight = 1.25f;
    public Transform groundCheck;
    public float groundDistance=0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded; //хранит значение коснулся земли или нет

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //создание сферы для проверки приземления
        if(isGrounded && velocity.y < 0) //проверка на приземление
        {
            velocity.y = -3f;
        }
        if (velocity.y < -12 && velocity.y >= -16)
        {
            HealthBar.fill -= 0.01f;
        }
        if (velocity.y < -16)
        {
            HealthBar.fill -= 0.01f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
