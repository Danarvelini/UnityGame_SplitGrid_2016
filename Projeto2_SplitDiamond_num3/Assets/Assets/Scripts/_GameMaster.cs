// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class _GameMaster : MonoBehaviour 
{

	#region Variables
	public GameObject p01;
	public GameObject p02;
	public GameObject lamp;
	public GameObject directLight; //Luz do mundo
	public GameObject spotLight; //Luz para a cena

	public Collider2D p01Collider;
	public Collider2D p02Collider;

	public Light lampLight;

	private int vidasp01 = 2, vidasp02 = 2;

	public GameObject enemyPreFab;
	#endregion


	void Awake()
	{
		p01 = GameObject.Find("Player01");
		p02 = GameObject.Find("Player02");
		lamp = GameObject.Find("Lamparina");
		directLight = GameObject.Find("Directional Light");
		spotLight = GameObject.Find("LuzParaScene (DesligarParaGameplayFinal)");

		p01Collider = p01.GetComponent<PolygonCollider2D>();
		p02Collider = p02.GetComponent<PolygonCollider2D>();
		lampLight = lamp.GetComponent<Light>();		

	}

	void Start () 
	{
		directLight.SetActive(false);
		spotLight.SetActive(false);
	}

	void Update () 
	{
		if (Input.GetKey(KeyCode.L))
		{
			directLight.SetActive(true);
			spotLight.SetActive(true);
		}
		else if (Input.GetKey(KeyCode.K))
		{
			directLight.SetActive(false);
			spotLight.SetActive(false);
		}

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	
	}

	public void ResetCurrentLevel()
	{
		//int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


}
