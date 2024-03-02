using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator 
{
    ShapeSettings settings;
    NoiseFilter noiseFilter;
    public ShapeGenerator(ShapeSettings settings)
    {
        this.settings = settings;
        noiseFilter = new NoiseFilter();
    }

    public Vector3 CalculatePoinOnPlanet(Vector3 pointOnUnitSphere)
    {
        float elevation = noiseFilter.Evalute(pointOnUnitSphere);
        return pointOnUnitSphere * settings.planetRadius * (1 + elevation); ;
    }
}
