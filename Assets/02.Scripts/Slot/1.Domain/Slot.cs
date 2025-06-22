using System;
using Unity.VisualScripting;
using UnityEngine;

public class Slot
{
    public string ID { get; private set; }      // 아이템, 스킬 등 여러가지를 찾기 위한 아이디
    public int Quantity { get; private set; }   // 현재 슬롯의 수가 다 찼냐?

    public static Slot Empty = new Slot("Empty", 0);

    public Slot(string id, int quantity)
    {
        // 이 슬롯은 null이어도 된다.
        if (Quantity < 0)
        {
            throw new Exception("수량은 0 밑으로 떨어질 수 없습니다.");
        }
        
        ID = id;
        Quantity = quantity;
        
    }
    
    public bool IsEmpty => Quantity == 0;

    // 수량 추가
    public void AddQuantity(string itemID, int quantity)
    {
        if (quantity < 0)
        {
            throw new Exception("음수를 더할 수 없습니다.");
        }

        if (IsEmpty)
        {
            ID = itemID;
        }
        
        Quantity += quantity;
        
    }

    // 수량 빼기
    public void SubQuantity(int quantity)
    {
        if (quantity < 0)
        {
            throw new Exception("음수를 뺄 수 없습니다.");
        }

        if (Quantity < quantity)
        {
            return;
        }
        
        Quantity -= quantity;

        if (!IsEmpty)
        {
            return;
        }

        this.ID = Empty.ID;
        this.Quantity = Empty.Quantity;
    }

    
    
}
