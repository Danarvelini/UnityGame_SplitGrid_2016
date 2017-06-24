// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TutorialScript : MonoBehaviour 
{

	#region Variables
	public KeyCode start, quit;
	public Text startTxt;

	#endregion



	void Start()
	{
	}

	void Update()
	{

		if (Input.GetKey(start))
			SceneManager.LoadScene("Prototipo_Fase01");
		
	}


}
