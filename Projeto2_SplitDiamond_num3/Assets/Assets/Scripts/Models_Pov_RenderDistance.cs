// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Models_Pov_RenderDistance : MonoBehaviour 
{

	#region Variables
	private MeshRenderer gobjRenderer;
	#endregion



	void Start()
	{
		gobjRenderer = gameObject.GetComponent<MeshRenderer>();
		gobjRenderer.enabled = true;
	}

	void Update()
	{

	}

	private void OnTriggerStay2D(Collider2D other)
	{
		gobjRenderer.enabled = true;
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
