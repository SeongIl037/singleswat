using System;
using UnityEngine;

public class UI_PopUp : MonoBehaviour
{
    private Action _closeAction;
    
    public void Open(Action action = null)
    {
        this.gameObject.SetActive(true);
        
        _closeAction += action;
        
        
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
        
        _closeAction?.Invoke();
        
    }
}
