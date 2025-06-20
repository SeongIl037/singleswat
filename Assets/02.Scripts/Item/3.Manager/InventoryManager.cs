using UnityEngine;
using System.Collections.Generic;
public class InventoryManager : Singletone<InventoryManager>
{
    //현재 존재하는 인벤토리들
    private List<Inventory> _inventories;
    
    protected override void Awake()
    {
        base.Awake();

        Init();
    }

    private void Init()
    {
        _inventories = new List<Inventory>();
        
    }
}
