using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
        health = 500;
	}

    // Update is called once per frame
    public void TakeDamage()
    {
        if(health > 0)
        {
            health = health = 100;
        }

        if(health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
