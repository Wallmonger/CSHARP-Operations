using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public Material mat;
    public Color c1;
    public Color c2;
    public bool canMove = false;    

    // These functions only works if we have a box collider
    void OnMouseOver()
    {
        mat.color = c1;
    }

    // 
    void OnMouseExit()
    {
        mat.color=c2;
    }

    // When you release the clic of the mouse
    private void OnMouseUp()
    {
         Destroy(gameObject);     
    }

    // When you press the clic of the mouse
    private void OnMouseDown()
    {
        
    }

    private void Update()
    {
        if (canMove)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += Vector3.right;
            }
        }
    }
}
