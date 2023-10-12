using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct EnviroMentalSt
{

    public int light;

    EnviroMentalSt(int light = 100)
    {
        this.light = light;
    }
};


public class Enviromental : SingleTon<Enviromental>
{



    
    protected new void Awake()
    {
        base.Awake();
    }


    
    static EnviroMentalSt enviro = new EnviroMentalSt();

    public static int enviroMental
    {
        get => enviro.light;
    }

}
