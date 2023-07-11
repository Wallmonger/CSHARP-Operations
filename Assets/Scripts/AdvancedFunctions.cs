using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedFunctions : MonoBehaviour
{
    public Color aliveColor;
    public Color deadColor;
    public int vie = 3;
    public string text = "";
    
    void Start()
    {
        // ChangeColor();

        int resultat = Add(1, 1);
        print(resultat);
        print(Add(resultat, 5));
        print(ConvertToFloat());
        InvokeRepeating("LifeDraining", 2f, 3f);

        print(ReturnTxt()); 

        text = ReturnTxt();
        

    }

    private void Update()
    {
        if (IsAlive())
        {
            ChangeColor(aliveColor);

        }
        else
        {
            ChangeColor(deadColor);
        }
    }

    void ChangeColor(Color c)
    {
        // Récupérer un composant avec la fonction GetComponent au lieu de l'instancier en tant que variable
         GetComponent<Renderer>().material.color = c;

    }

    int Add(int nb1, int nb2)
    {
        return nb1 + nb2;
    }

    float ConvertToFloat() 
    {
        return float.Parse("10");
    }

    bool IsAlive ()
    {
        if (vie > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }    

    string ReturnTxt () {
        return "test";
    } 

    void LifeDraining()
    {
        vie--;
        print("vie = " + vie);
    }
}
