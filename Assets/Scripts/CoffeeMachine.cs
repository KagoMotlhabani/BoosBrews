using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    public bool coffeeReady = false;
    public bool brewing = false;
    public float prepareTime = 5;
    public GameObject coffee, copyCoffee;
    public Boo boo;


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
            boo.holdingCoffee = true;
            boo.coffeeCup.SetActive(true);
            Destroy(copyCoffee);
        }
        

    }//end OnMouseDown

    IEnumerator MakeCoffee(){

        Debug.Log($"Brewing...");
        brewing = true;
        yield return new WaitForSeconds (prepareTime);
        Debug.Log("Brewed");
        coffeeReady = true;
        copyCoffee = Instantiate(coffee);//create a copy of the coffee gameobject to appear in scene
        brewing = false;
    }//end MakeCoffee

    public float GetPrepTime(){
        return prepareTime;
    }

    public void SetPrepTime(float newPrepTime){
        prepareTime = newPrepTime;
    }
}//end class
