using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public float timeDelay;
    public float waitTime = 10;
    public bool inCafe = false; //to determine whether customer is in the cafe
    public bool orderGiven = false;
    public bool happy = true; //customer eneters the cafe happy, if they have to wait too long, they will become angry
    public GameObject customer, customerCopy; //basically do the same as with the coffemachine scipt
    public MoneyManager money;
    public int coffeePrice = 10;

    // Start is called before the first frame update
    void Start()
    {   
        //gameObject.SetActive(false);
        
    }//end start

    // Update is called once per frame
    void Update()
    {  
        enterCafe();  
    }//end update 

    void enterCafe(){
        timeDelay += Time.deltaTime;

        if (timeDelay > 5 && inCafe == false){
            Debug.Log("A customer has entered the cafe");
            timeDelay = 0;
            inCafe = true;
            //once = true;
            //gameObject.SetActive(true);
        }
    }//end enterCafe  


    private void OnMouseDown()
    {
        if(inCafe == true){
            Debug.Log("Order given");
            orderGiven = true;
            //money.AddMoney(coffeePrice);
            MoneyManager.instance.AddMoney(coffeePrice);
        } else{
            Debug.Log("You don't have anything to give the customer");
        }
        
        
    }//ebd object is clicked

    IEnumerator LeaveCafe(){
        yield return new WaitForSeconds(5);
        Debug.Log("Customer has left");
    }

    IEnumerator WaitForOrder(int x){
        if(orderGiven == true){
            yield return new WaitForSeconds(10);

        }


    }//end WaitForOrder


}//end Customer
