using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/ItemSO")]
public class ItemSO : ScriptableObject
{
    [SerializeField]
    private EItemType _itemType;
    public EItemType ItemType => _itemType;
    
    [SerializeField]
    private string _description;
    public string Description => _description;
    
    [SerializeField]
    private string _name;
    public string Name => _name;
    
    [SerializeField]
    private int _id;
    public int Id => _id;
    
    [SerializeField]
    private int _purchasePrice;
    public int PurchasePrice => _purchasePrice;
    
    [SerializeField]
    private int _sellPrice;
    public int SellPrice => _sellPrice;
    
    [SerializeField]
    private Sprite _icon;
    public Sprite Icon => _icon;
}
