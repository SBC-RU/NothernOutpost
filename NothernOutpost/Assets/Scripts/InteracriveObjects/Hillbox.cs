using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hillbox : MonoBehaviour, Interactable
{
    public Sprite icons;
    public GameObject interactionIcon;
    public bool isOn;
    void Start()
    {
        //box.enabled = isOn;
    }
    public void iconActive() //����������� �������� ��������
    {
        
    }

    public string GetDescription()
    {
        if (isOn) 
        {
            return "<color=yellow>������������ [E]</color>";
            
        }
        return null;
        //return "<color=green>������������ [E]</color>";
    }
    public Sprite Geticon()
    {
        if (isOn)
        {
            return icons;

        }
        return null;
        //return "<color=green>������������ [E]</color>";
    }
    public void Interact()
    {

        HealthBar.fill += 0.7f;
        Destroy(gameObject);
    }
}
