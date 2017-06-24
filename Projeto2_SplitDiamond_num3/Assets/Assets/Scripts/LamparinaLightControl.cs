// Daniel Nordhausen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LamparinaLightControl : MonoBehaviour 
{

	#region Variables
	private Light lampLight;

	public float minIntensity = 2f;
	public float maxIntensity = 2.2f;
	private float finalIntensity;

	public float minRange = 50f;
	public float maxRange = 55f;
	private float finalRange;


	#endregion



	void Start () 
	{
		lampLight = GetComponent<Light>();
	}
	
	void Update () 
	{
		finalIntensity = Random.Range(minIntensity, maxIntensity);
		finalRange = Random.Range(minRange, maxRange);

		lampLight.intensity = finalIntensity;
		lampLight.range = finalRange;
	}

	

}
