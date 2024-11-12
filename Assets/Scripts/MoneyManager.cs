using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;
    public TMP_Text moneyText;
    public int money;
    // Start is called before the first frame update

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

    public void AddMoney(int amount){
        money = money + amount;
        moneyText.text = "MONEY: $" + money;

    }//end Add Money
}//end  class
