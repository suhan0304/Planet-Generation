using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseFilter
{
    Noise noise = new Noise();

    public float Evalute(Vector3 point)
    {
        float noiseValue = noise.Evaluate(point);
    }
}
