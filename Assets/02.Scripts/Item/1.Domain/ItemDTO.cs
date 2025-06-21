using UnityEngine;

public class ItemDTO
{
    public readonly EItemType ItemType;
    public readonly string ItemId;
    public readonly string ItemName;
    public readonly string ItemDescription;
    public readonly int PurchasePrice;
    public readonly int SellPrice;
    public readonly Sprite ItemImage;

    public ItemDTO(EItemType itemType, string itemId, string itemName, string itemDescription, int purchasePrice, int sellPrice, Sprite itemImage)
    {
        ItemType = itemType;
        ItemId = itemId;
        ItemName = itemName;
        ItemDescription = itemDescription;
        PurchasePrice = purchasePrice;
        SellPrice = sellPrice;
        ItemImage = itemImage;
        
    }

    public ItemDTO(Item item)
    {
        ItemType = item.ItemType;
        ItemId = item.ItemId;
        ItemName = item.ItemName;
        ItemDescription = item.ItemDescription;
        PurchasePrice = item.PurchasePrice;
        SellPrice = item.SellPrice;
        ItemImage = item.ItemImage;
    }
}
        
    