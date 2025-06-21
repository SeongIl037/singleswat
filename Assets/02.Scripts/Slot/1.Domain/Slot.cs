using System;
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
    
    // 슬롯의 개수가 0이면 false, 1개 이상이라면 true => 슬롯에 있는 숫자와 이미지를 끄고 키기 위함;
    public bool SlotEmptyCheck()
    {
        if (Quantity == 0)
        {
            return false;
        }
        
        return true;
    }

    
    
}
