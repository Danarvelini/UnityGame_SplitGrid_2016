// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovEach : MonoBehaviour 
{

	#region Variables
	//public float enemyVel;

	//private SpriteRenderer gobjRenderer;

	public speedType enemyVel;
	public movementType movType;

	public enum movementType
	{
		HORIZONTAL,
		VERTICAL, 
		DIAGONAL
	}

	public enum speedType
	{
		SUPER_SLOW = 07,
		SLOW = 14,
		MEDIO = 25,
		FAST = 36,
		SUPER_FAST = 43
	}

	private Vector3 enemyPos;
	#endregion

	

	void Start()
	{
		enemyPos = gameObject.transform.position;

		//gobjRenderer = gameObject.GetComponent<SpriteRenderer>();
		//gobjRenderer.enabled = false;
	}

	
	void Update()
	{
		// Debug.Log(gameObject.name + " speed = " + ((int)enemyVel));

		if (movType == movementType.VERTICAL)
		{
			gameObject.transform.position = new Vector3(enemyPos.x, enemyPos.y + ((int)enemyVel) * Mathf.Sin(Mathf.PI * Time.time), transform.position.z);
		}
		if (movType == movementType.HORIZONTAL)
		{
			gameObject.transform.position = new Vector3(((int)enemyVel) * Mathf.Sin(Mathf.PI * Time.time), enemyPos.y, transform.position.z);
		}
		if (movType == movementType.DIAGONAL)
		{
			gameObject.transform.position = new Vector3(((int)enemyVel) * Mathf.Sin(Mathf.PI * Time.time), enemyPos.y + ((int)enemyVel) * Mathf.Sin(Mathf.PI * Time.time), transform.position.z);
		}

	}

	//Simulando FOV (Campo de visão)
	//private void OnTriggerEnter2D(Collider2D other)
	//{
	//	gobjRenderer.enabled = true;
	//}

	//private void OnTriggerExit2D(Collider2D collision)
	//{
	//	gobjRenderer.enabled = false;
	//}

}
