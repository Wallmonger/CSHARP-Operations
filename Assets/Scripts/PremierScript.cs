using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PremierScript h�rite de MonoBehaviour, permet d'acc�der � des fonctionnalit�s de unity.
public class PremierScript : MonoBehaviour
{

   

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        gameObject.name = "Object";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
