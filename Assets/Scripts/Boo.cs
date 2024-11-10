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
        //Boo must prepare the Order
        if(readyToGo == true && customer.inCafe == true && busy == false){
            //StartCoroutine(PrepareOrder());

            //StartCoroutine(WalkToKitchen());
            //StartCoroutine(PrepareOrder());
            //StartCoroutine(WalkFromKitchen());
            
            //readyToGo = false;


        }


    }


    //Player Clicks on Boo
    void OnMouseDown(){ 
        moveCounter++;
        //If the customer is ready to order
       
        if(customer.inCafe == true && busy == false){
        
            readyToGo = true;
            StartCoroutine(Walk(walkTime) );
           /*  
           switch(moveCounter){
                case 0:
                Debug.Log($"Walking to kitchen...");
                StartCoroutine(Walk(walkTime));
                break;

                case 1:
                //Debug.Log($"In kitchen... PREP");
                StartCoroutine(PrepareOrder());
                break;

                case 2:
                Debug.Log($"Walking back...");
                StartCoroutine(Walk(walkTime));
                break;

                case 3:
                Debug.Log($"RESET");
                break;

            }

*/




        } else{
            Debug.Log($"No customers to service");
        }
        

  
    }//end OnMouseDown

    //This is a the cycle Boo will follow when preparing the customers order
    IEnumerator PrepareOrder(){
        //busy = true;

        //Debug.Log($"Walking to the Kitchen...");
        //moveCounter++;
        //yield return new WaitForSeconds(walkTime);
        
        Debug.Log($"In the Kitchen...Preparing Order");
        //moveCounter++;
        yield return new WaitForSeconds (prepareTime);
        Debug.Log($"Done preparing");

        //Debug.Log($"Walking back to customer");
        //moveCounter++;
        //yield return new WaitForSeconds(walkTime);
        //moveCounter++;

        //Debug.Log($"Ready for the next one");
        //busy = false;
        //moveCounter = 0;
        //yield return null;
    }

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

    }//end wwalk


}//end class
