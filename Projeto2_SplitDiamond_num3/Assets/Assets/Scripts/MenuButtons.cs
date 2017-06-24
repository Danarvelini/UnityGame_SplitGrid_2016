using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour 
{

	void Update()
	{
		if (Input.GetKey(KeyCode.T)) 
		{
			Application.Quit ();
		}

		if (Input.GetKey(KeyCode.R)) 
		{
			SceneManager.LoadScene ("Prototipo_Fase01");
		}

		if (Input.GetKey(KeyCode.G)) 
		{ 
			SceneManager.LoadScene ("MenuHelp");
		}		
	}
	
	public void StartGame ()
	{
		SceneManager.LoadScene ("Prototipo_Fase01");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void HelpMenu ()
	{
		SceneManager.LoadScene ("Help");
	}
}
