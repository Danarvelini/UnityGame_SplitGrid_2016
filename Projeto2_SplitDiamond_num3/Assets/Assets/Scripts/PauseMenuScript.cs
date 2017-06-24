// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenuScript : MonoBehaviour 
{

	#region Variables
	GameObject pauseMenu;
	bool paused;

	//_GameMaster _gm;
	#endregion

	

	void Start () 
	{
		paused = false;
		pauseMenu = GameObject.Find("PauseMenu");
	}
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			paused = !paused;
			//Debug.Log("Clicou para pausar");
		}
		if (paused)
		{
			pauseMenu.SetActive(true);
			Time.timeScale = 0;
			//Debug.Log("Esta ativando");
		}
		else if (!paused)
		{
			pauseMenu.SetActive(false);
			Time.timeScale = 1;
			//Debug.Log("Esta desativando");
		}
	}

	public void Continue()
	{
		paused = false;
	}

	public void ResetLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

}
