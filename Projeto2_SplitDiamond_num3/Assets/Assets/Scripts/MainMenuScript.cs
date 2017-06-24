// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuScript : MonoBehaviour 
{

	#region Variables
	public KeyCode start, quit;
	public Text startTxt;
	
	#endregion



	void Start () 
	{
		Time.timeScale = 1; //para concertar o problema que a cena nao tinha animacao quando acessada pelo menu de pause
	}
	
	void Update () 
	{
		
		if (Input.GetKey(start))
			SceneManager.LoadScene("Tutorial");

		else if (Input.GetKey(quit))
			Application.Quit();


		//startTxt.color = 
	}

	

}
