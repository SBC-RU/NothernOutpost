using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI message;
    public bool dead = false;
    public Image value_HP;
    public static float fill; //остаток здоровья


    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }
    public void textMessage()
    {
        message.text = "ВЫ ПОГИБЛИ";
    }
    // Update is called once per frame
    void Update()
    {
        if (fill > 0f)
        {
            //fill -= Time.deltaTime * 0.1f; //здоровье отнимается
        }
        if (fill <= 0f)
        {
            fill = 0f;
            dead = true;
        }
        if (dead)
        {
            fill = 0f;
            textMessage();
            PlayerMovement.speed = 0f;
            PlayerMovement.jumpHeight = 0f;
            MouseLook.mouseSensitivity = 0f;
        }
        

        if (fill > 1f)
        {
            fill = 1f;
        }

        value_HP.fillAmount = fill;
    }
}
