using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Namesandtypes : MonoBehaviour
{
    public int id;
    public Names[] NameObj;
    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] TextMeshProUGUI Category;
    [SerializeField] TextMeshProUGUI Characteristic;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjectID();
    }
    public void Object_Medkit()
    {
        id = 1;
    }
    public void Object_Milkpot()
    {
        id = 2;
    }
    public void Object_Tea()
    {
        id = 3;
    }
    public void Object_Fishpot()
    {
        id = 4;
    }
    void ObjectID()
    {
        //int i = Random.Range(0, tips.Length - 1);
        //Debug.Log(tips[i].Ru);

        if (Name)
        {
            Name.text = NameObj[id].Eng.ToString();
        }
        else
        {
            Debug.LogError("бяе окнун");
        }

        //comments_txt.text = "25345634t6345";
        //comments_txt.text = tips[1].Ru;
        //comments_txt.text = tips[2].Ru;
        //comments2.text = tips[1].Ru;

    }
}
