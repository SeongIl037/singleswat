using UnityEngine;

public class Inventory : MonoBehaviour
{
    // 인벤토리에 필요한 것들
    // 인벤토리 ID => 아이템들이 찾아갈 수 있도록 하기 위함
    public readonly int ID;
    // 현재 내 인벤토리에 있는 아이템들
    public readonly ItemDTO[] Items;
    
}
