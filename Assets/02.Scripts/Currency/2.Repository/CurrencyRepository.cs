using System;
using UnityEngine;

public class CurrencyRepository
{
    private const string SAVE_KEY = "Currency";

    public void Save(CurrencyDTO dto)
    {
        CurrencySaveData save = new CurrencySaveData(dto);
        string jsonData = JsonUtility.ToJson(save);
        
        PlayerPrefs.SetString(SAVE_KEY, jsonData);
        
        PlayerPrefs.Save();
    }

    public CurrencySaveData Load()
    {
        if (!PlayerPrefs.HasKey(SAVE_KEY))
        {
            return null;
        }
        
        string jsonData = PlayerPrefs.GetString(SAVE_KEY);
        CurrencySaveData save = JsonUtility.FromJson<CurrencySaveData>(jsonData);
        
        return save;
    }
}

[Serializable]
public class CurrencySaveData
{
    public int Gold;
    public int Red;
    public int Blue;
    public int White;
        
    public CurrencySaveData(CurrencyDTO currency)
    {
        Gold = currency.Gold;
        Red = currency.Red;
        Blue = currency.Blue;
        White = currency.White;
    }
}