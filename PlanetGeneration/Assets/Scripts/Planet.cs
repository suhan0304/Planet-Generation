using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [Range(2, 25)]
    public int resolution = 10;

    MeshFilter[] meshFilters;
    TerrainFace[] terrainFaces;


    void Initialized()
    {
        meshFilters = new MeshFilter[6]; //정육면체이므로 6개
        terrainFaces = new TerrainFace[6]; 

        for (int i = 0; i < 6; i++)
        {
            GameObject meshObj = new GameObject("mesh");
            meshObj.transform.parent = transform;

            meshObj.AddComponent<MeshRenderer>().sharedMaterial = new Material(Shader.Find("Standard"));
            meshFilters[i] = meshObj.AddComponent<MeshFilter>();
            meshFilters[i].sharedMesh = new Mesh();

            terrainFaces = new TerrainFace(meshFilters[i].sharedMesh, )
        }
    }
}
