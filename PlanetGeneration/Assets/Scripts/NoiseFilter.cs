using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseFilter
{
    NoiseSettings settings;
    Noise noise = new Noise();

    public NoiseFilter(NoiseSettings settings) 
    { 
        this.settings = settings; 
    }

    public float Evalute(Vector3 point)
    {
        float noiseValue = 0;
        float frequency = settings.baseRoughness;
        float amplitude = 1;

        for (int i = 0; i < settings.numLayers; i++)
        {

        }

        return noiseValue * settings.strength;
    }
}
