using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    public bool coffeeReady = false;
    public float prepareTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        StartCoroutine(MakeCoffee());

    }//end OnMouseDown

    IEnumerator MakeCoffee(){

        Debug.Log($"Brewing...");
        yield return new WaitForSeconds (prepareTime);
        Debug.Log("Brewed");
        coffeeReady = true;
    }//end MakeCoffee
}//end class
