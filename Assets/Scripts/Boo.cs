using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boo : MonoBehaviour
{
    public Customer customer;
    public float walkTime = 2;
    public float prepareTime = 4;
    public bool readyToGo = false;
    public bool busy = false;

    public int moveCounter = 0; //to keep track of where in the cycle Boo is

    //public bool orderReceived = false;
    // Start is called before the first frame update
    void Start()
    {
        
  
    }

    // Update is called once per frame
    void Update()
    {


    }


    //Player Clicks on Boo
    void OnMouseDown(){ 
        moveCounter++;
        //If the customer is ready to order
       
        if(customer.inCafe == true && busy == false){
        
            readyToGo = true;
            busy = true;
            StartCoroutine(Walk(walkTime) );


        } else{
            Debug.Log($"Can't do anything right now");
        }
        

  
    }//end OnMouseDown


    IEnumerator Walk(float walking){
        //moveCounter++;
        Debug.Log($"Walking");
        while(walking > 0){
            //put walking stuff here
            //Debug.Log($"Walking... " + walkTime  + "seconds left...");
            walking -= Time.deltaTime;
            yield return null;
        }//end while 
        Debug.Log($"Done walking");
        busy = false;

    }//end wwalk


}//end class
