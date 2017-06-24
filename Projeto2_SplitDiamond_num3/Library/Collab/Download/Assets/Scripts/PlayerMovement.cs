// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour 
{

	#region Variables
	public KeyCode moveUp, moveDown, moveRight, moveLeft, runButton, rushButton;

	public Rigidbody2D playerRB;

	//private Vector3 velocity = Vector3.zero;

	private float speed;
	public float smoothTime = 0.3f;
	public float speedWalk, speedRun;
	public float rushForce = 600.0f;
	#endregion


	void Start()
	{

	}

	void Update()
	{

		WalkRunMovement();
		RushMovement();
		transform.up = playerRB.velocity; //C�digo para alterar qual a posi��o que o jogador est� olhando, ir� rotacionar o objeto de acordo com o movimento
	}

	void RushMovement()
	{
		if (Input.GetKeyDown(rushButton))
		{
			playerRB.AddForce(new Vector2(0, 5) * rushForce);
			Debug.Log("Voce usou Rush");
		}
	}

	void WalkRunMovement()
	{
		Vector2 _rBody = GetComponent<Rigidbody2D>().velocity;


		Debug.Log("O speed esta em: " + speed);

		if (Input.GetKey(runButton))
		{
			speed = speedRun;
		}
		else
		{
			speed = speedWalk;
		}


		if (Input.GetKey(moveUp))
		{
			_rBody.y = speed;
			GetComponent<Rigidbody2D>().velocity = _rBody;
		}
		else if (Input.GetKey(moveDown))
		{
			_rBody.y = -speed;
			GetComponent<Rigidbody2D>().velocity = _rBody;
		}
		else
		{
			_rBody.y = 0.0f;
			GetComponent<Rigidbody2D>().velocity = _rBody;
		}

		if (Input.GetKey(moveRight))
		{
			_rBody.x = speed;
			GetComponent<Rigidbody2D>().velocity = _rBody;
		}
		else if (Input.GetKey(moveLeft))
		{
			_rBody.x = -speed;
			GetComponent<Rigidbody2D>().velocity = _rBody;
		}
		else
		{
			_rBody.x = 0.0f;
			GetComponent<Rigidbody2D>().velocity = _rBody;
		}
	}

}
