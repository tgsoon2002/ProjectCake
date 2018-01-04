using System.Collections;
using System.Collections.Generic;
using GlobalVar;
using UnityEngine;
using UnityEngine.AI;

public class CustomerControl : MonoBehaviour
{
    #region Data Member
    public Transform newDestination;
    NavMeshAgent agent;
    public float distance = 50f;
    public CustomerState currentState = CustomerState.BUYING;
    private bool moving = false;





    #endregion
    #region Getter Setter
    #endregion
    #region Built - in Method
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance < 0.001f && moving)
            {
                Debug.Log("Customer at counter");
                newDestination.GetComponent<DisplayCounter>().AddWaitingCustomer(this);
                moving = false;
            }
        }
    }
    #endregion
    #region Public Method
    /// <summary>
    /// Set destination called by customer manager, point to where to go.
    /// </summary>
    /// <param name="des"></param>
    public void SetDestiantion(Transform des)
    {
        newDestination = des;
        Debug.Log(des.position);
        agent.SetDestination(des.position);
        moving = true;
    }


    #endregion
    #region Private Method



    private void DecideWhereToGo()
    {

    }
    #endregion

    // Use this for initialization

}