//Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
	#region Variables
	public GameObject player;
	#endregion

	void Start ()
	{
		
	}
	
	void Update ()
	{
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		SceneManager.LoadScene("Prototipo_Fase01");
	}
}
