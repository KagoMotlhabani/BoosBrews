using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    public bool coffeeReady = false;
    public bool brewing = false;
    public float prepareTime = 5;


    void OnMouseDown(){
        if(coffeeReady == false){
            if(brewing == false && coffeeReady == false){
            StartCoroutine(MakeCoffee());
            }else{
                Debug.Log("Already brewing coffee");
            }
        }else{
            Debug.Log("Coffee collected");
            coffeeReady = false;
        }
        

    }//end OnMouseDown

    IEnumerator MakeCoffee(){

        Debug.Log($"Brewing...");
        brewing = true;
        yield return new WaitForSeconds (prepareTime);
        Debug.Log("Brewed");
        coffeeReady = true;
        brewing = false;
    }//end MakeCoffee
}//end class
