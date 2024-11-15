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
            Destroy(copyCoffee);
        }
        

    }//end OnMouseDown

    IEnumerator MakeCoffee(){

        Debug.Log($"Brewing...");
        brewing = true;
        yield return new WaitForSeconds (prepareTime);
        Debug.Log("Brewed");
        coffeeReady = true;
        copyCoffee = Instantiate(coffee);
        brewing = false;
    }//end MakeCoffee

    
}//end class
