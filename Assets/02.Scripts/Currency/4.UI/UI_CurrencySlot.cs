using System;
using TMPro;
using UnityEngine;

public class UI_CurrencySlot : MonoBehaviour
{
    // 텍스트 리프레시
    public TextMeshProUGUI GoldText;
    public TextMeshProUGUI RedText;
    public TextMeshProUGUI WhiteText;
    public TextMeshProUGUI BlueText;
    
    public void Refresh(CurrencyDTO currencydto)
    {
        GoldText.text = currencydto.Gold.ToString();
        RedText.text = currencydto.Red.ToString();
        WhiteText.text = currencydto.White.ToString();
        BlueText.text = currencydto.Blue.ToString();
    }
}
