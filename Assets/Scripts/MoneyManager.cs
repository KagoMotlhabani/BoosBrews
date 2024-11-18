using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;
    public TMP_Text moneyText;
    public float money;


    private void Awake() {
        instance = this;
    }
    void Start()
    {
        moneyText.text = "MONEY: $" + money;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney(float amount){
        money = money + amount;
        moneyText.text = "MONEY: $" + money;

    }//end Add Money

    public void RemoveMoney(float amount){
        money = money - amount;
        moneyText.text = "MONEY: $" + money;
    }
}//end  class
