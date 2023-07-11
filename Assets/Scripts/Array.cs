using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public int[] tab;
    void Start()
    {
        tab[2] = 5;
        /*for(int i =  0; i < tab.Length; i++)
        {
            print(tab[i]);
        }*/

        /*foreach (int val in tab)
        {
            print(val);
        }*/

        /*print(tab.Length);*/
    }

    
    void Update()
    {
        
    }
}
