using UnityEngine;

public class UI_Button : MonoBehaviour
{
    public EPopupMenu menu;
    public void Open()
    {
        PopupManager.Instance.OpenMenu(menu);
        Debug.Log($"{menu}");
    }

    // 맵 프리뷰 열리는 창 
    public void OpenPreview()
    {
        PopupManager.Instance.OpenMenu(EPopupMenu.UI_PreviewMap);
    }
}
