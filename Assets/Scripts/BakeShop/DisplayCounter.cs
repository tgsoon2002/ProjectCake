using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCounter : MonoBehaviour
{

    public List<CustomerControl> listCustomerWaiting;
    public string[] listFood;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddWaitingCustomer(CustomerControl newCus)
    {
        listCustomerWaiting.Add(newCus);
    }
}
