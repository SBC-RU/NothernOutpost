using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnduranceBar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI message;
    public static float accuracy; //коэффициент точности (дл€ стрельбы)
    public static float impactforce; //коэффициент силы удара (ближний бой)
    public Image value_EU;
    public static float fill; //остаток сил

    void Start()
    {
        fill = 1f; //значение выносливости по умолчанию 100%
    }
    public void textMessage() //текст предупреждение
    {
        //message.text = "Ќ≈ќЅ’ќƒ»ћќ ќ“ƒќ’Ќ”“№";
    }

    void Update()
    {
        if (fill > 0f) //если выносливость > 0, то она может быть уменьшено
        {
            //fill -= Time.deltaTime * 0.1f; //силы отнимаютс€
        }

        if (fill >= 0.8f) 
        {
            if (fill > 1f) //если выносливость > 100%, оно соответствует 100%
            {
                fill = 1f;
            }
            if (HealthBar.fill < 1f) //если выносливость > 100%, оно соответствует 100%
            {
                fill -= Time.deltaTime * 0.02f; //выносливость отнимаетс€ -2%
                HealthBar.fill += Time.deltaTime * 0.01f; //здоровье восстанавливаетс€ +1%
            }
            accuracy = 1f; //коэф точности 1
            impactforce = 1f; //коэф силы удара 1
            PlayerMovement.speed = 14f; //скорость 14
        }
        if (fill >= 0.3f && fill<0.8f)
        {
            accuracy = 0.87f; //коэф точности 0.87
            impactforce = 0.6f; //коэф силы удара 0.6
            PlayerMovement.speed = 12f; //скорость 12
        }
        if (fill < 0.3f)
        {
            accuracy = 0.65f; //коэф точности 0.65
            impactforce = 0.4f; //коэф силы удара 0.4
            PlayerMovement.speed = 10f; //скорость 10
            //textMessage();
        }

        value_EU.fillAmount = fill;

    }
}
