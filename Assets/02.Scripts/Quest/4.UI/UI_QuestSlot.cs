using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_QuestSlot : MonoBehaviour
{
    private int _slotID;
    // 의뢰에서 보여줄 정보
    public TextMeshProUGUI Title;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI TotalReward;
    public Image Preview;

    public Button StageButton;
    
    
    // 의뢰 정보들 초기화 하기 => 정렬 적용시 정보들을 바꿔주기 위함
    public void OnEnable()
    {
        StageButton.onClick.AddListener(OnStage);   
    }

    public void Init(Quest quest, Sprite sprite)
    {
        Title.text = quest.Name;
        Description.text = quest.Description;
        TotalReward.text = quest.TotalReward.ToString();
        
        Preview.sprite = sprite;
        _slotID = (int)quest.Stage + 1;
    }
    
    public void OnStage()
    {
        StageManger.Instance.LoadQuests(_slotID);
    }
    
}
