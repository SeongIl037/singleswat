using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Currency : MonoBehaviour
{
    // 현재 내가 가지고 있는 재화를 나타낼 것 ==> 리프레시를 시켜주는 사람
    // 여기서 뻗어나간다. -> 1. 게임 화면 (HUD)에 표시되는 재화 2. 상점에 들어갔을 때 상점에 표시되는 재화
    [SerializeField] private List<UI_CurrencySlot> _slots;

    private void Awake()
    {
        CurrencyManager.Instance.DataOnChanged += SlotRefresh;
    }
    private void Start()
    {
        SlotRefresh();
    }

    private void SlotRefresh()
    {
        CurrencyDTO dto = CurrencyManager.Instance.MyCurrencyDTO;
        
        foreach (UI_CurrencySlot slot in _slots)
        {
            slot.Refresh(dto);
        }   
    }
}
