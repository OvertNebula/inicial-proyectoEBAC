using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseNormal
{

    // las sumas + son instancias
    // las multiplicaciones * son estaticas
    int nuemro1;
    int numero2;

    public ClaseNormal(int param1, int param2)
    {
        param1 = nuemro1;
        param2 = numero2;
    }

    public ClaseNormal(float param1 , float param2)
    {
        param1 = (int)nuemro1;
        param2 = (int)numero2;
    }
    public int SumarEnteriros(int a,int b)
    {
        return a + b;
    }

    public float SumarFlotantes(float a, float b)
    {
        return a + b;
    }

    public static float MultiplicarFlotantes(float a, float b)
    {
        return a * b;
    }
}
