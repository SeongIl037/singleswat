using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_PreviewMap : UI_PopUp
{
    private Camera _camera;
    // 현재 층수
    private int _currentFloor = 6;
    private int _maxFloor = 8;
    private int _minFloor = 6;

    private void Awake()
    {
        _camera = GameObject.FindGameObjectWithTag("MiniMapCamera").GetComponent<Camera>();
    }

    private void OnEnable()
    {
        ShowFloor(_currentFloor);
    }

    public void IncreaseFloor()
    {
        _currentFloor = Mathf.Clamp(_currentFloor + 1, _minFloor, _maxFloor);
        ShowFloor(_currentFloor);
    }

    public void DecreaseFloor()
    {
       _currentFloor = Mathf.Clamp(_currentFloor - 1, _minFloor, _maxFloor);
        ShowFloor(_currentFloor);
    }
    
    // 층수에 따라서 
    private void ShowFloor(int currentFloor)
    {
        // Nothing으로 전환
        _camera.cullingMask = 1 << 0;
        // 현재 층 보여주기
        _camera.cullingMask = 1 << currentFloor;
    }

    private void OnDisable()
    {
        _currentFloor = _minFloor;
    }
}
