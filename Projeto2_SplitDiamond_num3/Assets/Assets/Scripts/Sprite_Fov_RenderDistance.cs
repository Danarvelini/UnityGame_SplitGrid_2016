// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sprite_Fov_RenderDistance : MonoBehaviour 
{

	#region Variables
	private SpriteRenderer gobjRenderer;
	#endregion



	void Awake()
	{
		gobjRenderer = gameObject.GetComponent<SpriteRenderer>();
		gobjRenderer.enabled = false;
	}

	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		gobjRenderer.enabled = true;
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		gobjRenderer.enabled = false;
	}



}
