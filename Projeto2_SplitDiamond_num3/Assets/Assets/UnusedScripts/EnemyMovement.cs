//Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	#region Variables
	public GameObject enemy01, enemy02, enemy03;

	public float enemy01Vel = 10, enemy02Vel = 15, enemy03Vel = 20;
	private Vector3 enemy01Pos, enemy02Pos, enemy03Pos;
	#endregion

	void Start ()
	{
		enemy01Pos = enemy01.transform.position;
		enemy02Pos = enemy02.transform.position;
		enemy03Pos = enemy03.transform.position;
	}
	
	void Update ()
	{
		enemy01.transform.position = new Vector3(enemy01Pos.x, enemy01Pos.y + enemy01Vel * Mathf.Sin(Mathf.PI * Time.time), transform.position.z);
		enemy02.transform.position = new Vector3(enemy02Vel * Mathf.Sin(Mathf.PI * Time.time), enemy02Pos.y, transform.position.z);
		enemy03.transform.position = new Vector3(enemy03Vel * Mathf.Sin(Mathf.PI * Time.time), enemy03Pos.y, transform.position.z);

	}
}
