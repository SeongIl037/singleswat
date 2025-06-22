using System;
using System.Collections.Generic;
using UnityEngine;


public class InventoryRepository
{
    private const string SAVE_KEY = "Inventory";
    
    public void Save(List<Inventory> inventory)
    {
        AllInventoriesSaveData saveData = new AllInventoriesSaveData();

        foreach (Inventory inventoryItem in inventory)
        {
            InventorySaveData save = new InventorySaveData(inventoryItem);
            saveData.Datas.Add(save);
        }

        string json = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString(SAVE_KEY, json);
        
        PlayerPrefs.Save();
    }

    public AllInventoriesSaveData Load()
    {
        if (!PlayerPrefs.HasKey(SAVE_KEY))
        {
            return null;
        }
        string jsonData = PlayerPrefs.GetString(SAVE_KEY);
        AllInventoriesSaveData save = JsonUtility.FromJson<AllInventoriesSaveData>(jsonData);
        
        return save;
    }
}

[Serializable]
public class AllInventoriesSaveData
{
    public List<InventorySaveData> Datas;

    public AllInventoriesSaveData()
    {
        Datas = new List<InventorySaveData>();
    }
}

[Serializable]
public class InventorySaveData
{
    public string InventoryID;
    public int MaxCount;
    public List<Slot> Slots;
    

    public InventorySaveData(Inventory inventory)
    {
        InventoryID = inventory.ID;
        MaxCount = inventory.MaxSlotCount;
        Slots = inventory.Slots;
    }
}
