using System;
using UnityEngine;
using GameEngineProfiler;

public class Grid : ILoggable
{
    private int _width;
    private int _length;
    private int[,] _cells;
    [SerializeField] private int _cellSize;
    [SerializeField] private int _groundHeight;

    public int[,] Cells
    {
        get { return _cells; }
        set { _cells = value; }
    }

    public int CellSize
    {
        get { return _cellSize; }
        set { _cellSize = value; }
    }

    public Grid(int width, int length, int cellSize)
    {
        _width = width;
        _length = length;
        _cellSize = cellSize;
        _cells = new int[width, length];
        _groundHeight = 1;
        
        int wlen = _cells.GetLength(0);
        int llen = _cells.GetLength(1);
        
        for (int x = -5; x < wlen; x++)
        {
            for (int z = -5; z < llen; z++)
            {
                Vector3 thisCell = new Vector3(x * _cellSize, _groundHeight, z * _cellSize);
                Vector3 westCell = new Vector3(x-1 * _cellSize, _groundHeight, z * _cellSize);
                Vector3 eastCell = new Vector3(x+1 * _cellSize, _groundHeight, z * _cellSize);
                Vector3 northCell = new Vector3(x * _cellSize, _groundHeight, z+1 * _cellSize);
                Vector3 southtCell = new Vector3(x * _cellSize, _groundHeight, z-1 * _cellSize);
                Debug.DrawLine(thisCell, westCell, Color.red, Single.PositiveInfinity, false);
                Debug.DrawLine(thisCell, eastCell, Color.red, Single.PositiveInfinity, false);
                Debug.DrawLine(thisCell, northCell, Color.red, Single.PositiveInfinity, false);
                Debug.DrawLine(thisCell, southtCell, Color.red, Single.PositiveInfinity, false);
                
            }
        }
        
        Debug.Log("Created grid!");
    }

    public string Log()
    {
        return $"Grid width: " + _width + " length: " + _length;
    }
}
