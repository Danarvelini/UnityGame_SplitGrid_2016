// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArcadePUCCampinas;

public class PlayerMovement02 : MonoBehaviour 
{

	#region Variables
	public KeyCode moveUp, moveDown, moveRight, moveLeft, runButton, rushButton;

	public Rigidbody2D playerRB;

	//private Vector3 velocity = Vector3.zero;

	private float speed;
	public float smoothTime = 0.3f;
	public float speedWalk, speedRun;
	public float rushForce = 600.0f;
	private Vector2 _rBody;
	#endregion


	void Start()
	{
		Vector2 _rBody = playerRB.velocity;

	}

	void Update()
	{

		WalkRunMovement();
		//RushMovement();
		//transform.up = playerRB.velocity; //C�digo para alterar qual a posi��o que o jogador est� olhando, ir� rotacionar o objeto de acordo com o movimento


		if (_rBody != Vector2.zero)
		{
			float angle = Mathf.Atan2(_rBody.y, _rBody.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}


		float x = Input.GetAxis("HORIZONTAL1") * Time.deltaTime * speedWalk;
		float y = Input.GetAxis("VERTICAL1") * Time.deltaTime * speedWalk;


		//transform.Translate(new Vector3(x, y, 0));

		//if (Input.GetButtonDown("VERDE0"))
		//{
		//	transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 180);
		//}
	}

	//void RushMovement()
	//{
	//	if (Input.GetKeyDown(rushButton))
	//	{
	//		playerRB.AddForce(new Vector2(0, 5) * rushForce);
	//		Debug.Log("Voce usou Rush");
	//	}
	//}

	void WalkRunMovement()
	{
		//Vector2 _rBody = playerRB.velocity;


		//Debug.Log("O speed do player esta em: " + speed);

		//Muda a velocidade para correr
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
			playerRB.velocity = _rBody;
		}
		else if (Input.GetKey(moveDown))
		{
			_rBody.y = -speed;
			playerRB.velocity = _rBody;
			//gameObject.transform.rotation = new Vector3(-180, -180, 360);
		}
		else
		{
			_rBody.y = 0.0f;
			playerRB.velocity = _rBody;
		}


		if (Input.GetKey(moveRight))
		{
			_rBody.x = speed;
			playerRB.velocity = _rBody;
		}
		else if (Input.GetKey(moveLeft))
		{
			_rBody.x = -speed;
			playerRB.velocity = _rBody;
		}
		else
		{
			_rBody.x = 0.0f;
			playerRB.velocity = _rBody;
		}
	}

}
