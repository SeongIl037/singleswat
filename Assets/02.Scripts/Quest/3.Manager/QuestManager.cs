using System.Collections.Generic;
using UnityEngine;

public class QuestManager : Singletone<QuestManager>
{
    [SerializeField]
    private List<QuestSO> _questSO;
    
    private List<Quest> _quests;
    public List<Quest> QuestList => _quests;
    
    private void Awake()
    {
        base.Awake();
        
        Init();
    }
    // 데이터 초기화하기
    private void Init()
    {
        _quests = new List<Quest>();

        foreach (QuestSO data in _questSO)
        {
            _quests.Add(new Quest(data));
        }
    }
    
    
}
