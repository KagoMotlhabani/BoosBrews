using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boo : MonoBehaviour
{
    public Customer customer;
    public Vector2 kitchenPosition = new Vector2((float)12.43,(float)-0.54);
    public Vector2 startPosition;
    public float walkTime = 2f;
    public bool busy = false;
    public bool inKitchen = false;
    public bool holdingCoffee = false;
    public GameObject coffeeCup;
    public Tutorial tutorial;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        coffeeCup.SetActive(false);
        
    }


    //Player Clicks on Boo
    void OnMouseDown(){ 
        //If the customer is ready to order
       
        if(customer.inCafe == true && busy == false){
        
            busy = true;
            StartCoroutine(Walk(walkTime) );

        } else{
            Debug.Log($"Can't do anything right now");
        }
  
    }//end OnMouseDown


/*
Method that allows Boo to walk to the Kitchen in the designated time
*/
    IEnumerator Walk(float time){

        float timePassed = 0; 
        Debug.Log($"Walking");
        while(timePassed < time){
            
            //Either walk to the Kitchen (right) or walk to the Counter(left)
            if(inKitchen==false){
                transform.position = Vector2.Lerp(startPosition, kitchenPosition, timePassed/time);
                //transform.Translate(Vector2.right * Time.deltaTime);
            }else{
                transform.position = Vector2.Lerp(kitchenPosition, startPosition, timePassed/time);
                //transform.Translate(Vector2.left * Time.deltaTime);
            }
            
            timePassed += Time.deltaTime;
            yield return null;
        }//end while 
        Debug.Log($"Done walking");
        busy = false;
        if(holdingCoffee == true){
            if(tutorial.isEnabled == true){tutorial.EditTutorial(5);}
            Debug.Log($"Boo is holding the coffee");
        }
        inKitchen = !inKitchen; //flip the value of inKitchen

        if(inKitchen){
            //Debug.Log($"OK now click on COFFEEMACHINE");
            if(tutorial.isEnabled == true){
                tutorial.EditTutorial(1);
            }
        }

    }//end walk

    public float GetWalkTime(){
        return walkTime;
    }

    public void SetWalkTime(float newWalkTime){
        walkTime = newWalkTime;
    }


}//end class
