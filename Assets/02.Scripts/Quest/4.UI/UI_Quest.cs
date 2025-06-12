using System;
using UnityEngine;
using System.Collections.Generic;

public class UI_Quest : UI_PopUp
{
    // 슬롯 관리
    public List<UI_QuestSlot> Slots;
    // 슬롯 프리팹
    public GameObject QuestPrefab;
    public Transform QuestContainer;
    
    public List<Sprite> PreviewSprites;
    
    private void Start()
    {
        MakePrefabs();
        
        Refresh();
    }
    //슬롯 개수에 따라서 슬롯 칸에 프리팹 생성해서 넣어주기
    private void MakePrefabs()
    {
        for (int i = 0; i < QuestManager.Instance.QuestList.Count; i++)
        {
            GameObject slotPrefab = Instantiate(QuestPrefab, QuestContainer.parent, false);
            Slots.Add(slotPrefab.GetComponent<UI_QuestSlot>());
        }
    }
    //슬롯 UI정보 입력해주기
    private void Refresh()
    {
        List<Quest> quests = QuestManager.Instance.QuestList;
   
        for (int i = 0; i < Slots.Count; i++)
        {
            Slots[i].Init(quests[i], PreviewSprites[(int)quests[i].Stage]);
        }
    }
    
    
}
