using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicConst : MonoBehaviour
{
    //максимальный носимый боекомплект
    public static int bp12_maxsize;
    public static int bp5_maxsize;
    public static int bp9_maxsize;
    public static float accuracy; //коэффициент точности (для стрельбы)
    public static float impactforce; //коэффициент силы удара (ближний бой)
    // Start is called before the first frame update
    void Start()
    {
        bp12_maxsize = 10;
        bp5_maxsize = 62;
        bp9_maxsize = 45;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
