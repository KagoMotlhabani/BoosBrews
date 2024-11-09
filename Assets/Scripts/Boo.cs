using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boo : MonoBehaviour
{
    public Customer customer;
    public float walkTime = 2;
    public float prepareTime = 4;
    public bool readyToGo = false;

    //public bool orderReceived = false;
    // Start is called before the first frame update
    void Start()
    {
        
  
    }

    // Update is called once per frame
    void Update()
    {
        //Boo must prepare the Order
        if(readyToGo == true && customer.inCafe == true){
            StartCoroutine(PrepareOrder());
            readyToGo =false;
        }


    }


    //Player Clicks on Boo
    void OnMouseDown(){ 
        //If the customer is ready to order
        if(customer.inCafe == true){
            readyToGo = true;
        } else{
            Debug.Log($"No customers to service");
        }
        

  
    }//end OnMouseDown

    //This is a the cycle Boo will follow when preparing the customers order
    IEnumerator PrepareOrder(){
        Debug.Log($"Walking to the Kitchen...");
        yield return new WaitForSeconds(walkTime);

        Debug.Log($"In the Kitchen...Preparing Order");
        yield return new WaitForSeconds (prepareTime);

        Debug.Log($"Walking back to customer");
        yield return new WaitForSeconds(walkTime);

        Debug.Log($"Ready for the next one");


        //yield return null;
    }



}
