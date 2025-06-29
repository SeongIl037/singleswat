using System;
using UnityEngine;
public enum EStage
{
    Stage1,
    Stage2,
    Stage3,
    Stage4,
    Stage5,
    Stage6,
    
    Count
}

public enum ECurrencyType
{
    Gold,
    
    Count
}
public class Quest
{
    // 스테이지 상태, 이름, 소개
    public readonly EStage Stage;
    public readonly string Name;
    public readonly string Description;
    
    // 보상 숫자 => 총 보상 수 (enemy 숫자에 따른 골드)
    public readonly int EnemyCount;
    public readonly ECurrencyType CurrencyType;
    public readonly int IndividualReward;
    
    // 총 보상
    public readonly int TotalReward;

    // 생성자에서 한번 거르기
    public Quest(QuestSO data)
    {
        if (string.IsNullOrEmpty(data.Name))
        {
            throw new Exception("의뢰의 이름이 없습니다.");
        }
        
        Stage = data.Stage;
        Name = data.Name;

        if (string.IsNullOrEmpty(data.Description))
        {
            throw new Exception("퀘스트의 설명이 없습니다.");
        }
        
        Description = data.Description;

        if (data.Enemycount < 0)
        {
            throw new Exception("적이 없습니다.");
        }
        
        EnemyCount = data.Enemycount;
        CurrencyType = data.CurrencyType;

        if (data.IndvidualReward < 0)
        {
            throw new Exception("보상은 0보다 커야합니다.");
        }
        
        IndividualReward = data.IndvidualReward;
        TotalReward = IndividualReward * EnemyCount;
    }
    
}
