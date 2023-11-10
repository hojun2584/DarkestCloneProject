using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Study23_11_10 
{

    public static T Clamp<T>(this ref T curValue , T min , T max) where T : struct , IComparable
    {
        if (curValue.CompareTo(min) == -1)
            return curValue = min;
        else if (curValue.CompareTo(max) == 1)
            return curValue = max;
       
        return curValue;
    }

    public static void AlphaZero(this SpriteRenderer value) 
    {
        Color alphaZero = value.color;
        alphaZero.a = 0f;
        value.color = alphaZero;
    }

    public static void AlphaMax(this SpriteRenderer value)
    {
        Color alphaMax = value.color;
        alphaMax.a = 255f;
        value.color = alphaMax;
    }



}
