//Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


#region Variables

#endregion

public class EndFase : MonoBehaviour
{
	
	public GameObject endingMsg;
	
	void Start () 
	{
		endingMsg.SetActive (false);
	}

	void Update()
	{
		//if (Input.GetKey(KeyCode.R))
		//{
			
		//}
	}

	void OnTriggerEnter2D ()
	{
		Debug.Log ("Fim de Fase");

		endingMsg.SetActive (true);
	}

	
}
