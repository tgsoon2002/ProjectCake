using cakeslice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Manager : MonoBehaviour
{

    #region Data Member
    public Transform[] listCounter;
    public Transform[] listCakeDisplay;
    public static Shop_Manager _instance;
    #endregion
    #region Getter Setter
    public Vector3 PayLocation
    {
        get { return listCounter[0].GetChild(0).localPosition; }
    }
    public Transform[] DisplayList
    {
        get { return listCakeDisplay; }
    }
    #endregion
    #region Built - in Method

    private void Awake()
    {
        _instance = this;
    }

    // Use this for initialization
    void Start()
    {
        foreach (Transform counter in listCounter)
        {
            counter.GetComponent<Outline>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
    #region Public Method

    /// <summary>
    /// Player go to specific location like counter, oven, dough...
    /// </summary>
    /// <param name="loc"></param>
    public void PlayerReachLocation(Transform loc)
    {
        foreach (Transform counter in listCounter)
        {
            if (counter == loc)
            {
                Debug.Log("Reach " + counter.name);
                return;
            }
        }
        Debug.Log("not here");
    }

    public void PlayerGotoLocaton(Vector3 loc)
    {

    }

    #endregion
    #region Private Method
    #endregion
}