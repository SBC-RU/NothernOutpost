using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milkpot : MonoBehaviour, Interactable
{
    public Sprite icons; //слот для картинки

    public bool isOn; //переменная для проверки состояния


    public string GetDescription() //вывод подсказки
    {
        if (isOn)
        {
            return "<color=yellow>Использовать [E]</color>";

        }
        return null;

    }
    public Sprite Geticon() //вывод картинки
    {
        if (isOn)
        {
            return icons;

        }
        return null;

    }
    public void Interact() //профит от использования (и судьба объекта)
    {
        if (Backpack.milkpot < 4)
        {
            Backpack.milkpot += 1;
            Destroy(gameObject);
        }
        //HealthBar.fill += 0.25f;
    }
}
