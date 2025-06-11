using System;
using UnityEngine;
using System.Collections.Generic;

public class UI_Quest : UI_PopUp
{
    // 슬롯 관리
    public List<UI_QuestSlot> Slots;
    
    public List<Sprite> PreviewSprites;
    public MapPreviewController MapPreviewController;
    
    private void Start()
    {
        Refresh();
    }

    private void Refresh()
    {
        List<Quest> quests = QuestManager.Instance.QuestList;
   
        for (int i = 0; i < Slots.Count; i++)
        {
            Slots[i].Init(quests[i], PreviewSprites[(int)quests[i].Stage]);
        }
    }
    
    
}
