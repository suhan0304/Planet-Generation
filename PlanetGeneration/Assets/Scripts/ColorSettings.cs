using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ColorSettings : ScriptableObject
{
    public Material planetMaterial;

    public class BiomeColorSettings
    {
        public class Biome
        {
            public Gradient gradient;
            [Range(0, 1)]
            public float startHeight;
        }
    }
}
