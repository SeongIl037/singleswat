using System;
using UnityEngine;

public class CheckTest : MonoBehaviour
{
    private Currency currency;
    private void Awake()
    {
        currency = new Currency(100, 100, 100, 100);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrencyManager.Instance.AddCurrency(currency);   
        }
    }
}
