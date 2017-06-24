using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour 
{

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene ("Prototipo_Fase01");
		}
	}

	public void ResetFase ()
	{
		SceneManager.LoadScene ("Prototipo_Fase01");
	}
}
