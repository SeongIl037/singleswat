using System;
using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    // 인벤토리에 필요한 것들
    // 인벤토리 ID => 아이템들이 찾아갈 수 있도록 하기 위함
    public readonly string ID;
    public readonly int MaxSlotCount;
    
    
    // 현재 내 인벤토리에 있는 아이템들
    public readonly List<Slot> Slots;

    public Inventory(string id, int max, List<Slot> slots)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new Exception("인벤토리 아이디가 없습니다.");
        }
        if (max <= 0)
        {
            throw new Exception("슬롯은 비어있을 수 없습니다.");
        }
        
        ID = id;
        MaxSlotCount = max;
        Slots = slots;
        
    }
    
    // 인벤토리에 슬롯 추가하기
    public bool AddItemToInventory(Slot slot)
    {
        if (IsFullInventory(MaxSlotCount))
        {
            Slots.Add(slot);
            return true;
        }

        return false;
    }
    // 인벤토리가 꽉 찼는지 확인하기
    private bool IsFullInventory(int max)
    {
        return Slots.Count <= max;
    }
    
    // 아이템 제거하기 => 인벤토리에서 빼내기
    public void RemoveItemFromInventory(string id)
    {
        if (Slots.Count <= 0)
        {
            return;
        }

        if (HasItem(id))
        {
            
        }
    }
    
    // 아이템을 얼마나 가지고 있을 수 있나요? => 기타, 소비는 여러개 가능 but 장비는 여러개 불가
 
    // 현재 인벤토리에 아이템이 존재하는가? => 인벤토리 안에 아이템 , 비교할 아이템 아이디
    private bool HasItem(string id)
    {
        foreach (Slot slot in Slots)
        {
            if (slot.ID == id)
            {
                return true;
            }
        }
        return false;
    }
    
}
