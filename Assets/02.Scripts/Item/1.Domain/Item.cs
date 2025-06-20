using System;
using UnityEngine;

public enum EItemType
{
    Equipment,
    Consumable,
    ETC,
    
    Count
}
public class Item
{
    // 아이템 관련 정보
    public readonly EItemType ItemType;
    public readonly int ItemId;
    public readonly string ItemName;
    public readonly string ItemDescription;
    public readonly int PurchasePrice;
    public readonly int SellPrice;
    public readonly Sprite ItemImage;

    public Item(EItemType type, int id, string name, string description, int sell, int purchase, Sprite image)
    {
        // id는 없을 수 없다.
        if (id < 0)
        {
            throw new Exception("id는 음수가 될 수 없습니다.");
        }
        // name은 없을 수 없다.
        if (string.IsNullOrEmpty(name) || name.Length > 10)
        {
            throw new Exception("아이템 명이 없습니다.");
        }
        // description은 없을 수 없다.
        if (string.IsNullOrEmpty(description))
        {
            throw new Exception("상세 설명이 없습니다.");
        }
        // sell가격은 없을 수 없다.
        if (sell < 0)
        {
            throw new Exception("판매 가격은 음수가 될 수 없습니다.");
        }
        // purchase가격은 없을 수 없다.
        if (purchase < 0)
        {
            throw new Exception("구매 가격은 음수가 될 수 없습니다.");
        }
        // image는 없을 수 없다.
        if (image == null)
        {
            throw new Exception("아이템 이미지가 없습니다.");
        }
        
        ItemType = type;
        ItemId = id;
        ItemName = name;
        ItemDescription = description;
        PurchasePrice = purchase;
        SellPrice = sell;
        ItemImage = image;
        
    }

    public ItemDTO ToDTO()
    {
        return new ItemDTO(this);
    }
    

}
