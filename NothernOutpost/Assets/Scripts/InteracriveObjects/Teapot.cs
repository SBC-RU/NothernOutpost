using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teapot : MonoBehaviour, Interactable
{
    public Sprite icons; //слот для картинки

    public bool isOn; //переменная для проверки состояния


    public string GetDescription() //вывод подсказки
    {
        if (isOn)
        {
            return "<color=yellow>Выпить [E]</color>";

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
        if (Backpack.tea < 4)
        {
            Backpack.tea += 1;
            Destroy(gameObject);
        }
        //EnduranceBar.fill += 0.2f;
    }
}
