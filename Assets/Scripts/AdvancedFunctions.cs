using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedFunctions : MonoBehaviour
{
    public Material mat;
    public Color targetColor;
    
    void Start()
    {
        ChangeColor(targetColor);
    }

    void ChangeColor(Color c)
    {
        mat.color = c;
    }
    
}
