using UnityEngine;

public class UI_Button : MonoBehaviour
{
    public EPopupMenu menu;
    public void Open()
    {
        PopupManager.Instance.OpenMenu(menu);
        Debug.Log($"{menu}");
    }
    
}
