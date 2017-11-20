using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Customer_Manager : MonoBehaviour
{

    #region Data Member
    public List<GameObject> wayPointList;
    public Transform payLocation;
    public List<CustomerControl> CustomerList;
    #endregion
    #region Getter Setter
    #endregion
    #region Built - in Method

    // Use this for initialization
    void Start()
    {
        // CustomerList
        CustomerList[0].SetDestiantion(wayPointList[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
    #region Public Method
    #endregion
    #region Private Method
    #endregion

}
