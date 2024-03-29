﻿using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class BWEffect : MonoBehaviour
{
    public float intensity;
    private Material material;
    public float transformationTime;
    // Creates a private material used to the effect
    void Awake()
    {
        material = new Material(Shader.Find("Hidden/BWSHADER"));
    }

    // Postprocess the image
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (intensity == 0)
        {
            Graphics.Blit(source, destination);
            return;
        }
        material.SetFloat("_bwBlend", intensity);
        Graphics.Blit(source, destination, material);
    }
}