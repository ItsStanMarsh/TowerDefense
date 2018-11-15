using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GridSystem script;
    public GameObject cam;

    public void Start()
    {
        cam = GameObject.Find("Main Camera");
        Move();
    }

    public void Move()
    {
        int enemX = Mathf.RoundToInt(transform.position.x - 1);
        int enemZ = Mathf.RoundToInt(transform.position.z);

        if (!cam.GetComponent<GridSystem>().CheckObjectInFront(enemX,enemZ))
        {
            transform.position = new Vector3(enemX, 0.5f, enemZ);
            cam.GetComponent<GridSystem>().FillArray(enemX, enemZ, 1);
            cam.GetComponent<GridSystem>().FillArray(enemX + 1, enemZ, 0);
        }

        Invoke("Move", 4f);
    }


}
