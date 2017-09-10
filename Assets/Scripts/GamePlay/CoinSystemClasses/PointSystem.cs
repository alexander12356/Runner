using System;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public static PointSystem Instance;

    public Action<int> OnPointChanged;

    private int _currentPoints = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddPoint(int value)
    {
        _currentPoints += value;
        OnPointChanged.Invoke(_currentPoints);
    }
}
