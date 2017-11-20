using System.Collections;
using System.Collections.Generic;
using GlobalVar;
using UnityEngine;
using UnityEngine.AI;

public class CustomerControl : MonoBehaviour {
    #region Data Member
    public Vector3 newDestination;
    NavMeshAgent agent;
    public float distance = 50f;
    public CustomerState currentState = CustomerState.BUYING;
    #endregion
    #region Getter Setter
    #endregion
    #region Built - in Method
    void Awake () {
        agent = GetComponent<NavMeshAgent> ();
    }

    // Update is called once per frame
    void Update () {

    }
    #endregion
    #region Public Method
    public void SetDestiantion (Vector3 des) {
        Debug.Log (des);
        agent.SetDestination (des);
    }
    #endregion
    #region Private Method

    private void DecideWhereToGo () {

    }
    #endregion

    // Use this for initialization

}