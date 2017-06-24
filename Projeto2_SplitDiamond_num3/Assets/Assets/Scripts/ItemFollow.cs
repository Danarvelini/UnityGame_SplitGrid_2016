// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemFollow : MonoBehaviour 
{

	#region Variables
	public GameObject p01, p02, lamp;
	public Camera mainCam;
	private bool insideItem;
	private object yield;
	#endregion

	void Start ()
	{
		insideItem = false;
	}

	private void OnTriggerStay2D(Collider2D collision)
	{		
		GetItem();
		Debug.Log("Esta no trigger");
	}

	//private void OnTriggerExit2D(Collider2D collision)
	//{

	//}

	void GetItem ()
	{
		if (lamp.tag == "lamparina" && Input.GetKeyDown(KeyCode.R) && insideItem == false)
		{
			Debug.Log("Pegou lamparina p01");

			lamp.GetComponent<SpriteRenderer>().enabled = false;
			lamp.transform.position = p01.transform.position;
			lamp.transform.SetParent(p01.transform);
			insideItem = true;	
		}
		if (lamp.tag == "lamparina" && Input.GetKeyDown(KeyCode.O) && insideItem == false)
		{
			Debug.Log("Pegou lamparina p02");

			lamp.GetComponent<SpriteRenderer>().enabled = false;
			lamp.transform.position = p02.transform.position;
			lamp.transform.SetParent(p02.transform);
			insideItem = true;
		}
	}

	private void Update()
	{
		if (lamp.transform.position == p01.transform.position)
			DropItem();
		

		if (lamp.transform.position == p02.transform.position)
			DropItem();

	}

	void DropItem()
	{
		 if(Input.GetKey(KeyCode.Space) && insideItem == true)
		{
			Debug.Log("Dropou lamparina");

			lamp.GetComponent<SpriteRenderer>().enabled = true;
			lamp.transform.parent = null;
			insideItem = false;
		}
	}


}
