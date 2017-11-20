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
        if (Input.GetMouseButtonDown(0))
        {

            //create a ray cast and set it to the mouses cursor position in game
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, distance))
            {
                //draw invisible ray cast/vector
                Debug.DrawLine(ray.origin, hit.point);
                //log hit area to the console
                Debug.Log(hit.point);
                agent.SetDestination(hit.point);

            }


            Debug.Log(agent.destination);
            //= newDestination;
        }
    }
    #endregion
    #region Public Method
    #endregion
    #region Private Method
    #endregion

    // Use this for initialization

}
