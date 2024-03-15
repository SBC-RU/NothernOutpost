using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI message;
    public static bool dead = false; //хранит информацию о смерти
    public Image value_HP;
    public static float fill; //остаток здоровья


    
    void Start()
    {
        fill = 1f; //значение здоровья по умолчанию 100%
    }
    public void textMessage() //текст предупреждение
    {
        //message.text = "ВЫ ПОГИБЛИ";
    }

    void Update()
    {
        if (fill > 0f) //если здоровье > 0, то оно может быть уменьшено
        {
            //fill -= Time.deltaTime * 0.1f; //здоровье отнимается
        }
        if (fill <= 0f) //если здоровье <= 0 то герой погиб
        {
            fill = 0f;
            dead = true;
        }
        if (dead) //если герой мертв, здоровье 0, вывод текста о смерти, скорость перемещения = 0, прыжок = 0, вращение камеры 0
        {
            fill = 0f;
            EnduranceBar.fill = 0f;
            //textMessage();
            PlayerMovement.speed = 0f;
            PlayerMovement.jumpHeight = 0f;
            MouseLook.mouseSensitivity = 0f;
        }
        

        if (fill > 1f) //если здоровье > 100%, оно соответствует 100%
        {
            fill = 1f;
        }

        value_HP.fillAmount = fill;
    }
}
