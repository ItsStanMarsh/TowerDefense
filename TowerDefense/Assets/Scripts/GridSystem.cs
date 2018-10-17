using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public int[,] grid;

    private void Start()
    {
        grid = new int[9, 3];

        for(int x = 0; x < 9; x++)
        {
            for(int y = 0; y < 3; y++)
            {
                grid[x, y] = 0;
            }
        }
    }

    public int FillArray(int x, int y)
    {
        grid[x, y] = 0;
        return 0;
    }
}
