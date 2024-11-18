using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public GameObject UpgradePanel;
    public Boo boo;
    public Customer customer;
    public CoffeeMachine coffeeMachine;
    public float walkUpgradeCost = 30;
    public float prepUpgradeCost = 35;
    // Start is called before the first frame update
    void Start()
    {
        UpgradePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeWalkTime(){
        if(MoneyManager.instance.money >= walkUpgradeCost){
            Debug.Log($"You have enough money");
            Debug.Log("You have:" + MoneyManager.instance.money);
            MoneyManager.instance.RemoveMoney(walkUpgradeCost);

            //adjust the walkTime
            float currentWalkTime = boo.GetWalkTime();
            float newWalkTime = currentWalkTime - ((float)0.25 * currentWalkTime);
            boo.SetWalkTime(newWalkTime);
        }else{
            Debug.Log("Insufficient Funds to upgrade Walk"); 
        }
        
        
    }

    public void UpgradePrepTime(){
        if(MoneyManager.instance.money >= prepUpgradeCost){
            Debug.Log($"You have enough money");
            Debug.Log("You have:" + MoneyManager.instance.money);
            MoneyManager.instance.RemoveMoney(prepUpgradeCost);

            //adjust the prepare time
            float currentPrepTime = coffeeMachine.GetPrepTime();
            float newPrepTime = currentPrepTime - ((float)0.35 * currentPrepTime);
            coffeeMachine.SetPrepTime(newPrepTime);


        }else{
            Debug.Log("Insufficient Funds to upgrade Brew Time"); 
        }

    }

    

    // MoneyManager.instance.AddMoney(coffeePrice);
}//end class
