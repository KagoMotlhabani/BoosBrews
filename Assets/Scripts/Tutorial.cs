using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public TMP_Text tutorialText;
    public GameObject tutorialPanel;
    public bool isEnabled = true;
    public string[] tutorial = {
        "A customer has arrived and would like coffee. Click on Boo to go to the kitchen.",
        "Click on the coffee machine to prepare coffee.",
        "Wait while the coffee brews...",
        "Click on the coffee to give it to Boo.",
        "Click on Boo to return to the customer.",
        "Click on the customer to deliver the coffee and receive payment.",
        "And that's it! You can purchase upgrades by clicking on the 'UPGRADES' button in the top left corner. Happy Playing!"

    };
    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = "Welcome to Boo's Brews. Let's wait for a customer";
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled == false){
            tutorialPanel.SetActive(false);
        }
    }

    public void EditTutorial(int num){
        tutorialText.text = tutorial[num];
    }//end change text

    public void DisableTutorial(){
        isEnabled = false;
    }
}//end class
