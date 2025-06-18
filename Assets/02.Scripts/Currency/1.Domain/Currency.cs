using System;
using Unity.VisualScripting;
using UnityEngine;
public class Currency
{
    // 들어가야할 것 : 현재 가지고 있는 재화(골드, 약 종류 - 빨강, 파랑, 흰)
    public int Gold { get; private set; }
    public int Red { get; private set; }
    public int White { get; private set; }
    public int Blue { get; private set; }
    public string ErrorMessage;

    public Currency(int gold = 0 , int red = 0 , int white =0, int blue = 0)
    {
        // 규칙 : 재화들은 0보다 작으면 안된다,
        if (gold < 0)
        {
            throw new Exception("골드는 0보다 작을 수 없습니다.");
        }

        if (red < 0)
        {
            throw new Exception("빨간 약은 0보다 작을 수 없습니다.");
        }

        if (white < 0)
        {
            throw new Exception("흰 약은 0보다 작을 수 없습니다.");
        }

        if (blue < 0)
        {
            throw new Exception("파란 약은 0보다 작을 수 없습니다.");
        }
        
        Gold = gold;
        Red = red;
        White = white;
        Blue = blue;
        
    }
    
    // 재화 사용
    private void SpendCurrency(Currency currency)
    {
        if (!CanSpendCurrency(currency))
        {
            return;
        }
        
        Gold -= currency.Gold;
        Red -= currency.Red;
        White -= currency.White;
        Blue -= currency.Blue;
    }
    
    // 재화 얻기
    public void AddCurrency(Currency currency)
    {
        Gold += currency.Gold;
        Red += currency.Red;
        White += currency.White;
        Blue += currency.Blue;
    }

    public bool CanSpendCurrency(Currency currency)
    {
        
        return Gold >= currency.Gold 
               && Red >= currency.Red 
               && White >= currency.White
               && Blue >= currency.Blue;
    }
    // 재화 확인하기 (UI용)
    public bool CanSpendCurrency(Currency currency, out string errorMessage)
    {
        errorMessage = "";
        
        if (Gold < currency.Gold)
        {
            errorMessage = "골드가 모자랍니다.";
            return false;
        }

        if (Red < currency.Red)
        {
            errorMessage = "빨간 약이 부족합니다.";
            return false;
        }

        if (White < currency.White)
        {
            errorMessage = "흰 약이 부족합니다.";
            return false;
        }

        if (Blue < currency.Blue)
        {
            errorMessage = "파란 약이 부족합니다.";
            return false;
        }
        
        return true;
    }
    public CurrencyDTO ToDTO(Currency currency)
    {
        return new CurrencyDTO(currency.Gold, currency.Red, currency.White, currency.Blue);
    }
}
