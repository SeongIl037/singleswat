using System;
using System.Collections.Generic;
using UnityEngine;

public enum EPopupMenu
{
    UI_Option,
    UI_Shop,
    UI_Quest,
    UI_Map,
    
    
    count
}

public class PopupManager : Singletone<PopupManager>
{
    // 스택으로 빼주기 : 먼저 열린 팝업을 먼저 끄기 위함
    private Stack<UI_PopUp> _popupStack = new Stack<UI_PopUp>();
    public List<UI_PopUp> PopUps = new List<UI_PopUp>();
    
    
    // 업데이트 : ESC 누르면 UIMenu열기
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_popupStack.Count > 0)
            {
                UI_PopUp pop = _popupStack.Pop();
                pop.Close();
                
            }
            else
            {
                OpenMenu(EPopupMenu.UI_Option); 
            }
        }
    }

    public void OpenMenu(EPopupMenu menu, Action onClose = null)
    {
        OpenPopup(menu.ToString());
    }
    // 팝업 메뉴 열기
    private void OpenPopup(string menu, Action onClose = null)
    {
        foreach (UI_PopUp popup in PopUps)
        {
            if (popup.name == menu)
            {
                popup.Open(onClose);
                _popupStack.Push(popup);
                
            }
        }
    }
}
