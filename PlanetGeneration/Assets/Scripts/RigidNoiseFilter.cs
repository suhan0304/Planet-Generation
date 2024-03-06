using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidNoiseFilter
{
    NoiseSettings settings;
    Noise noise = new Noise();

    public RigidNoiseFilter(NoiseSettings settings)
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
            float v = 1 - Mathf.Abs(noise.Evaluate(point * frequency + settings.centre));
            v *= v;
            noiseValue += v * amplitude;
            frequency *= settings.roughness;
            amplitude *= settings.persistence;
        }

        noiseValue = Mathf.Max(0, noiseValue - settings.minValue);
        return noiseValue * settings.strength;
    }
}
