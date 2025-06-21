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
    
    public readonly string ItemName;
    public readonly string ItemDescription;

    public readonly string ItemId;
    public readonly int PurchasePrice;
    public readonly int SellPrice;
    public int Quantity { get; private set;}
    
    public readonly Sprite ItemImage;

    public Item(EItemType type, string id, string name, string description, int sell, int purchase,int quantity, Sprite image)
    {
        // id는 없을 수 없다.
        if (string.IsNullOrEmpty(id))
        {
            throw new Exception("아이템 아이디가 추가되지 않았습니다.");
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

        if (quantity < 0)
        {
            throw new Exception("아이템 개수는 음수가 될 수 없습니다.");
        }
        
        ItemType = type;
        ItemId = id;
        ItemName = name;
        ItemDescription = description;
        PurchasePrice = purchase;
        SellPrice = sell;
        Quantity = quantity;
        ItemImage = image;
        
    }
    // 아이템 개수 체크하기
    private bool CanAddItem(string itemID)
    {
        if (ItemId == itemID)
        {
            return true;
        }
        
        return false;
    }

    public void AddItem(string itemID, int quantitys)
    {
        if (!CanAddItem(itemID))
        {
            return;
        }

        Quantity += quantitys;
    }
    // // 착용 아이템 아이디
    // private string IDMaker(string characterID)
    // {
    //     string equipmentID = characterID;
    //
    //     if (ItemType == EItemType.Equipment)
    //     {
    //         equipmentID =$"{ItemId}" + "_" + characterID; 
    //         
    //         return equipmentID;   
    //     }
    //
    //     return ItemId;
    // }

    public ItemDTO ToDTO()
    {
        return new ItemDTO(this);
    }
    

}
