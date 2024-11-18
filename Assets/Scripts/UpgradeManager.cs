using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public Boo boo;
    public Customer customer;
    public float walkUpgradeCost;
    public float prepUpgradeCost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpgradeWalkTime(){
        boo.walkTime = 2;
        
    }

    void UpgradePrepTime(){

    }
}
