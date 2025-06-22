using UnityEngine;
using System.Collections.Generic;
public class InventoryManager : Singletone<InventoryManager>
{
    //현재 존재하는 인벤토리들
    private List<Inventory> _inventories;
    
    private Inventory _myInventory;
    private InventoryRepository _repository;
    protected override void Awake()
    {
        base.Awake();

        Init();
    }

    // 저장된 데이터가 있다면 불러오기
    private void Init()
    {
        _repository = new InventoryRepository();
        
        AllInventoriesSaveData saveData = _repository.Load();

        if (saveData == null)
        {
            // 빈 인벤토리 생성
            _inventories = new List<Inventory>();
            return;
        }
        
        // 모든 인벤토리에 있는 것들을 가져온다.
        foreach (InventorySaveData save in saveData.Datas)
        {
            Inventory inven = new Inventory(save.InventoryID, save.MaxCount, save.Slots);
            
            _inventories.Add(inven);
        }    
        
    }
    
    // 인벤토리에 아이템 추가하기
    public void AddItemToInventory(Inventory inventory, Slot slot)
    {
        inventory.AddItemToInventory(slot);
    }
    
    // 인벤토리에서 아이템 제거하기
    public void RemoveItemFromInventory(Inventory inventory, Slot slot)
    {
        
    }
    
    
}
