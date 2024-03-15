using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI message;
    public static bool dead = false; //������ ���������� � ������
    public Image value_HP;
    public static float fill; //������� ��������


    
    void Start()
    {
        fill = 1f; //�������� �������� �� ��������� 100%
    }
    public void textMessage() //����� ��������������
    {
        //message.text = "�� �������";
    }

    void Update()
    {
        if (fill > 0f) //���� �������� > 0, �� ��� ����� ���� ���������
        {
            //fill -= Time.deltaTime * 0.1f; //�������� ����������
        }
        if (fill <= 0f) //���� �������� <= 0 �� ����� �����
        {
            fill = 0f;
            dead = true;
        }
        if (dead) //���� ����� �����, �������� 0, ����� ������ � ������, �������� ����������� = 0, ������ = 0, �������� ������ 0
        {
            fill = 0f;
            EnduranceBar.fill = 0f;
            //textMessage();
            PlayerMovement.speed = 0f;
            PlayerMovement.jumpHeight = 0f;
            MouseLook.mouseSensitivity = 0f;
        }
        

        if (fill > 1f) //���� �������� > 100%, ��� ������������� 100%
        {
            fill = 1f;
        }

        value_HP.fillAmount = fill;
    }
}
