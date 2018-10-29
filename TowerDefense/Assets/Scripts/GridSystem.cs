using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MouseFollow
{
    public int[,] grid;

    public override void Start()
    {
        base.Start();
        grid = new int[9, 3];

        for(int x = 0; x < 9; x++)
        {
            for(int y = 0; y < 3; y++)
            {
                grid[x, y] = 0;
            }
        }
    }

    public void FillArray(int x, int y, int FillType)
    {
        grid[x, y] = FillType;
    }
}
