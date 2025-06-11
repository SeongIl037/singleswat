using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_QuestSlot : MonoBehaviour
{
    // 의뢰에서 보여줄 정보
    public TextMeshProUGUI Title;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI TotalReward;
    public Image Preview;
    
    // 의뢰 정보들 초기화 하기 => 정렬 적용시 정보들을 바꿔주기 위함
    public void Refresh(Quest quest)
    {
        Title.text = quest.Name;
        Description.text = quest.Description;
        TotalReward.text = quest.TotalReward.ToString();
        Preview.sprite = quest.Preview;
        
    }
}
