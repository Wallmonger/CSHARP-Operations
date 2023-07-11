using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    void Start()
    {
        /*print("Start");
        string test = "hello world";
        AfficherMessage(test);
        TestFunction();*/


        // InvokeRepeating works like setInterval (method, timer, repeatingRate)
        // Invoke works like setTimeout
        InvokeRepeating("TestFunction", 2f, 2f);
        Invoke("TestFunction2", 5f);

        
    }

    // Awake function is called before Start
    private void Awake()
    {
        print("Awake");
    }

    // Void doesn't return anything, only execute.
    void AfficherMessage(string msg)
    {
        print("Ce message est affiché :");
        print(msg);
    }

    void TestFunction()
    {
        print("This is invokeRepeating");
    }


    void TestFunction2 () 
    {
        print("This is invoke");
    }
    
}
