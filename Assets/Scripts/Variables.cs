using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Variables

    // Public can be changed in unity itself, Private only in the code
    public int age = 30;
    public float argent = 27.956f;
    public bool exempleBool = true;
    public string phrase;

    // Monobehaviour brings new variables
    public Color Couleur;
    public Material mat;
    

    // Start is called before the first frame update
    void Start()
    {
        age = int.Parse(phrase); // Transform into int
        mat.color = Couleur;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
