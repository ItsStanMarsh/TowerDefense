using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{

    public int health;
    public Text countText;

    // Use this for initialization
    void Start ()
    {
        health = 1000;
        SetCountText();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void SetCountText()
    { 
        if (health > 0)
        {
            countText.text = "Base: " + health.ToString();
        }
    }

    public void TakeDamage()
    {
        health = health - 100;
    }
}
