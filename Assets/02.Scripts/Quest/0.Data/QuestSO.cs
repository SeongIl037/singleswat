using UnityEngine;

[CreateAssetMenu(fileName = "QuestSO", menuName = "Scriptable Objects/QuestSO")]
public class QuestSO : ScriptableObject
{
    [SerializeField] private EStage _stage;
    public EStage Stage => _stage;
    
    [SerializeField] private string _name;
    public string Name => _name;
    
    [SerializeField] private string _description;
    public string Description => _description;
    
    [SerializeField] private int _enemyCount;
    public int Enemycount => _enemyCount;
    
    [SerializeField] private int _indvidualReward;
    public int IndvidualReward => _indvidualReward;
    
    [SerializeField] private ECurrencyType _currencyType;
    public ECurrencyType CurrencyType => _currencyType;
}
