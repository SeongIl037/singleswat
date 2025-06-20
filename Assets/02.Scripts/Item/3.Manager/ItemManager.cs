using System.Collections.Generic;
using UnityEngine;

public class ItemManager : Singletone<ItemManager>
{
    // 아이템 아이디를 가지고 아이템의 정보를 찾아온다.
    private Dictionary<int, ItemDTO> _items;
    public Dictionary<int, ItemDTO> Items => _items;
    //아이템
    [SerializeField] private List<ItemSO> _itemData;
    
    private List<Item> _item;
    public List<ItemDTO> Itemlist => _item.ConvertAll(i => i.ToDTO());
    
    protected override void Awake()
    {
        base.Awake();

        Init();
    }

    // 현재 존재하는 모든 아이템에 대한 것들을 모두 가져온다.
    private void Init()
    {
        _items = new Dictionary<int, ItemDTO>();
        
        // 세팅하기 (데이터를 
        foreach (ItemSO data in _itemData)
        {
            Item item = new Item(data.ItemType, data.Id, data.name, data.Description, data.SellPrice, data.PurchasePrice,data.Icon);
            
            _items.Add(item.ItemId, item.ToDTO());
        }
        
        
    }
    
    // 아이템 정보 전달하기
    public ItemDTO GetItemInfo(int id)
    {
        return _items[id];
    }
    
}
