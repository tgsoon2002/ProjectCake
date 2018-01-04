using cakeslice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    #region Data Member
    public Vector3 newDestination;
    NavMeshAgent agent;
    public float distance = 50f;
    public GameObject currentObject;
    public GameObject highLightObject;
    private bool moving = false;
    Vector3 destination = new Vector3();
    #endregion
    #region Getter Setter
    #endregion
    #region Built - in Method
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && hit.transform.gameObject != highLightObject && hit.transform.CompareTag("Selectable"))
        {
            if (highLightObject != null)
            {
                //  Debug.Log(highLightObject.name);
                highLightObject.GetComponent<Outline>().enabled = false;
            }

            highLightObject = hit.transform.gameObject;
            if (highLightObject.GetComponent<Outline>() != null)
            {
                highLightObject.GetComponent<Outline>().color = 0;
                highLightObject.GetComponent<Outline>().enabled = true;

            }

        }
        if (Input.GetMouseButtonDown(0))
        {
            if (highLightObject != null)
            {
                currentObject = highLightObject;
                FindDestination(currentObject.transform);
            }

        }
        // Debug.Log(agent.remainingDistance);
        if (!agent.pathPending)
        {
            if (agent.remainingDistance < 0.001f && moving)
            {

                transform.LookAt(currentObject.transform.position);

                Shop_Manager._instance.PlayerReachLocation(currentObject.transform);
                moving = false;
            }
            else
            {
                //hit.point
            }
        }


    }
    #endregion
    #region Public Method
    #endregion
    #region Private Method

    private void FindDestination(Transform obj)
    {
        Debug.Log("Set Destination");
        Transform tar = obj.Find("playerInteract");
        if (tar != null)
        {
            agent.SetDestination(tar.position);

        }
        else
        {
            agent.SetDestination(obj.position);
        }
        moving = true;
    }
    #endregion

    // Use this for initialization

}
