using System;
using GameEngineProfiler;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    private Grid _grid;
    private void Start()
    {
        _grid = new Grid(5, 5, 1);
    }
}