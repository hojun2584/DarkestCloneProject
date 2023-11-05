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

    IEnumerator LightTimer() 
    {

        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            enviro.light -= 1;
        }

    }
    
    static EnviroMentalSt enviro = new EnviroMentalSt();

    public static int enviroMental
    {
        get => enviro.light;
        set
        {
            if (value <= 100 && value >= 0)
                enviro.light = value;
            else
                enviro.light = 100;

            Enemy.enhencetAtk *= enviroMental;
        }
    }

}
