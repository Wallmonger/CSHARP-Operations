using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boucles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /* for loop
        for (int i = 0; i < 10; i++)
        {
            print("Value of i = " + i);
        }
        */
        
        int i = 0;
        while (i < 100) 
        {
            i++;
            print("bien le bonjour");
        }
        print("value of i is now equal to " + i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
