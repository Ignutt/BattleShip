using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CellType
{
    FREE,
    SHIP,
    SHOOTED,
    BLOCKED
}
public class Field
{
    List<List<CellType>> _field = new List<List<CellType>>();

    public Field(int h, int w)
    {
        Initialize(h, w);
    }

    private void Initialize(int h, int w)
    {
        for (int i = 0; i < h; i++)
        {
            _field.Add(new List<CellType>());
            for (int j = 0; j < w; j++)
            {
                _field[i].Add(CellType.FREE);
            }
        }
    }

    public bool CanInsertShip(int x, int y)
    {
        // TO DO
        return true;
    }

    public void InsertShip(int x, int y)
    {
        _field[y][x] = CellType.SHIP;
    }
}
