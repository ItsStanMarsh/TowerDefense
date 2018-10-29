using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public string[] keys;

    public virtual void Start()
    {
        keys = new string[1];      
    }

    public virtual void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            keys[0] = "Click";
        }
        if(Input.GetKeyDown("1"))
        {
            keys[0] = "Item1";
        }
        if (Input.GetKeyDown("2"))
        {
            keys[0] = "Item2";
        }
    }
}
