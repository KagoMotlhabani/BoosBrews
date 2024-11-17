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
    public Vector2 startPosition;
    public Vector2 endPosition = new Vector2( (float)-4.07, (float)-0.98);
    public MoneyManager money;
    public int coffeePrice = 10;
    public Boo boo;

    // Start is called before the first frame update
    void Start()
    {   
        startPosition = transform.position;
        Debug.Log(startPosition);
        
    }//end start

    // Update is called once per frame
    void Update()
    {  
        enterCafe();  
    }//end update 

    void enterCafe(){
        timeDelay += Time.deltaTime;

        if (timeDelay > 5 && inCafe == false){
            //StartCoroutine(CustoWalk() );
            StartCoroutine(CustomerWalkIn(3f) );
            //transform.Translate(Vector2.right * Time.deltaTime *3);
            timeDelay = 0;
            //once = true;
    
        }
    }//end enterCafe  

    private void OnMouseDown()
    {
        if(inCafe == true && boo.holdingCoffee == true){
            Debug.Log("Customer has received the coffee");
            orderGiven = true;
            MoneyManager.instance.AddMoney(coffeePrice);
            StartCoroutine(CustomerWalkOut(3f));
        } else{
            Debug.Log("You don't have anything to give the customer");
        }
        
        
    }//ebd object is clicked

//here time is how long the customer takes to enter
    IEnumerator CustomerWalkIn(float time){
        Debug.Log($"In coroutine");
        float timePassed = 0;
        while(timePassed < time){
            if(inCafe == false){
                transform.Translate(Vector2.right * Time.deltaTime *4);
            }
            
            timePassed += Time.deltaTime;
            yield return null;
        }
        Debug.Log($"A customer has entered the cafe");
        inCafe = true;
        
    }//end CustomerWalk

        IEnumerator CustomerWalkOut(float time){
        Debug.Log($"In coroutine"); 
        float timePassed = 0;
        while(timePassed < time){
            if(inCafe == true){
                transform.Translate(Vector2.left * Time.deltaTime *4);
            }
            
            timePassed += Time.deltaTime;
            yield return null;
        }
        Debug.Log($"A customer has left the cafe");
        inCafe = false;
        timeDelay = 0;
    }//end CustomerWalk

    IEnumerator WaitForOrder(int x){
        if(orderGiven == true){
            yield return new WaitForSeconds(10);

        }


    }//end WaitForOrder



}//end Customer
