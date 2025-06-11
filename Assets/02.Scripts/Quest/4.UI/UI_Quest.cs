using System;
using UnityEngine;
using System.Collections.Generic;
public class UI_Quest : MonoBehaviour
{
    // 슬롯 관리
    public List<UI_QuestSlot> Slots;
    // 맵 번호에 따라서 오브젝트 켜주기 (맵 오브젝트 프리팹 관리하기)
    public List<GameObject> MapPrefabs;

    private void Start()
    {
        Refresh();
    }

    private void Refresh()
    {
        List<Quest> quests = QuestManager.Instance.QuestList;
   
        for (int i = 0; i < Slots.Count; i++)
        {
            Slots[i].Refresh(quests[i]);
        }
    }
}
