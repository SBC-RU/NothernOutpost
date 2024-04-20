using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hillbox : MonoBehaviour, Interactable
{
    public Sprite icons;
    //public GameObject interactionIcon;
    public bool isOn;
    void Start()
    {
        //box.enabled = isOn;
    }
    public void iconActive() //отображение картинки предмета
    {
        
    }

    public string GetDescription()
    {
        if (isOn) 
        {
            return "<color=yellow>Поднять [E]</color>";
            
        }
        return null;
        //return "<color=green>Использовать [E]</color>";
    }
    public Sprite Geticon()
    {
        if (isOn)
        {
            return icons;

        }
        return null;
        //return "<color=green>Использовать [E]</color>";
    }
    public void Interact()
    {
        if (Backpack.medkit < 4 && HealthBar.fill > 0.45f)
        {
            Backpack.medkit += 1;
            Destroy(gameObject);
        }
        if (HealthBar.fill <= 0.45f)
        {
            HealthBar.fill += 0.7f;
            Destroy(gameObject);
        }
        //HealthBar.fill += 0.7f;
    }
}
