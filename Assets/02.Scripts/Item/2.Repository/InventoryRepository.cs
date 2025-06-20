using System.Collections.Generic;
using UnityEngine;


public class InventoryRepository : MonoBehaviour
{
    private const string SAVE_KEY = "Inventory";
    
    public void Save()
    {
           
    }

    public List<Inventory> Load()
    {
        
        return new List<Inventory>();
    }
}

public class InventorySaveData
{
    public int InventoryID;
    public List<ItemDTO> Items;

    public InventorySaveData(int inventoryID, List<ItemDTO> items)
    {
        InventoryID = inventoryID;
        Items = items;
    }
}
