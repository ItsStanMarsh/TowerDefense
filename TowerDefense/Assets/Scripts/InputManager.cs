using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public string[] keys;

    public void Start()
    {
        keys = new string[1];      
    }

    public virtual void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            keys[0] = "Click";
        }
        
    }
}
