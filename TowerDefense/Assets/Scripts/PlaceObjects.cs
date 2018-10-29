using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : GridSystem
{

    public override void Update()
    {
        base.Update();
        if (keys[0] == "Click")
        {
           if(GetItem())
           {
                if(grid[GetMousePosX(), GetMousePosZ()] != 1)
                {
                    FillArray(GetMousePosX(), GetMousePosZ(), 1);
                    PlaceItem(GetItem());
                }
           }
           keys[0] = "";
        }
    }

    public void PlaceItem(GameObject item)
    {
        Instantiate(item, new Vector3(GetMousePosX(), 0.5f, GetMousePosZ()),Quaternion.identity);
    }
}
