using System;
using UnityEngine;

public class CurrencyManager : Singletone<CurrencyManager>
{
    // 내 돈 가져오기
    private Currency _myCurrency;
    public CurrencyDTO MyCurrencyDTO => _myCurrency.ToDTO(_myCurrency);
    
    public event Action DataOnChanged;
    
    protected override void Awake()
    {
        base.Awake();
        
        Init();
    }

    private void Init()
    {
        //저장된 내 커렌시 가져오기
        // 커렌시가 있다면 가져오고, 없다면 currency 생성하기 => 초기값 0,0,0,0
        _myCurrency = new Currency();
    }

    // 재화 먹어버림
    public void AddCurrency(Currency currency)
    {
        _myCurrency.AddCurrency(currency);
        DataOnChanged?.Invoke();
    }
    // 재화 써버림
    public void SpendCurrency(Currency currency)
    {
        _myCurrency.CanSpendCurrency(currency);
        DataOnChanged?.Invoke();
    }
       
}
