using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Manager : MonoBehaviour {

	#region Data Member
	public Transform[] listCounter;
	#endregion
	#region Getter Setter
	public Vector3 PayLocation {
		get { return listCounter[0].GetChild (0).localPosition; }
	}
	#endregion
	#region Built - in Method

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	#endregion
	#region Public Method
	#endregion
	#region Private Method
	#endregion 
}