using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.M)) 
		{
			SceneManager.LoadScene ("MenuPrincipal");
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene ("Prototipo_Fase01");
		}
		
	}
}
