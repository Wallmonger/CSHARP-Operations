using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedFunctions : MonoBehaviour
{
    public Color targetColor;
    
    
    void Start()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        // Récupérer un composant avec la fonction GetComponent au lieu de l'instancier en tant que variable
        GetComponent<Renderer>().material.color = targetColor;
        GetComponent<Rigidbody>().useGravity = true;
    }
    
}
