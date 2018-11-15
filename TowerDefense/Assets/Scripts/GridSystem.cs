using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MouseFollow
{
    public int[,] grid1;

    public override void Start()
    {
            base.Start();
            grid1 = new int[9, 3];

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    grid1[x, y] = 0;
                }
            }

            Debug.Log("fill");
    }

    public void FillArray(int x, int y, int FillType)
    {
        grid1[x, y] = FillType;
    }

    public bool CheckObjectInFront(int posX, int PosZ)
    {
        if(grid1[posX,PosZ] == 0)
        {
            return false;
        } else
        {
            return true;
        }
    }
}