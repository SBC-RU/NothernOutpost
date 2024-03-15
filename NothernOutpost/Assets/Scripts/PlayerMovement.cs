using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    [SerializeField] TextMeshProUGUI message;
    public static float speed = 12f;
    public float gravity = -9.81f; //коэфициент гравитации
    public static float jumpHeight = 1.25f;
    public Transform groundCheck;
    public float groundDistance=0.4f;
    public LayerMask groundMask;
    public LayerMask groundMaskRad;
    Vector3 velocity;
    bool isGrounded; //хранит значение коснулся земли или нет
    bool isGroundedRad;

    void hilldown()
    {
        HealthBar.fill -= Time.deltaTime * 0.5f;
    }
    void hilldown_radiation()
    {
        HealthBar.fill -= Time.deltaTime * 0.1f;
    }
    void hilldown_radiationProtect()
    {
        HealthBar.fill -= Time.deltaTime * 0.001f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //создание сферы для проверки приземления
        isGroundedRad = Physics.CheckSphere(groundCheck.position, groundDistance, groundMaskRad);
        if (isGrounded && velocity.y < 0) //проверка на приземление
        {
            velocity.y = -3f;
        }
        if (velocity.y < -12 && velocity.y >= -16)
        {
            Invoke("hilldown", 1);
        }
        if (velocity.y < -16)
        {
            Invoke("hilldown", 1);
        }
        if (isGroundedRad)
        {
            velocity.y = -3.2f;
            isGrounded = true;
            if (Protection.fill < 0.25f)
            {
                message.text = "<color=yellow>ПОКИНЬТЕ ОПАСНУЮ ЗОНУ</color>";
                Invoke("hilldown_radiation", 5);
            }
            else 
            {
                message.text = "<color=green>ЗАЩИТА ДЕЙСТВУЕТ ОГРАНИЧЕННОЕ ВРЕМЯ</color>";
                Invoke("hilldown_radiationProtect", 30);
            }
        }
        if (!isGroundedRad)
        {
            message.text = " ";
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButton("Jump") && isGrounded)
        {
            EnduranceBar.fill -= 0.01f;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
