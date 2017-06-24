// Daniel Nordhausen

using UnityEngine;


public class CameraFollow : MonoBehaviour 
{

	#region Variables
	public Vector2 velocity;
	public Vector3 minCamPos;
	public Vector3 maxCamPos;

	public float smoothTimeX;
	public float smoothTimeY;
	
	public GameObject lampTarget;

	public bool bounds;

	#endregion


	void Start()
	{
		//lampTarget = GameObject.FindGameObjectWithTag("lamparina");
	}
	
	void FixedUpdate () 
	{
		float posX = Mathf.SmoothDamp(transform.position.x, lampTarget.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp(transform.position.y, lampTarget.transform.position.y, ref velocity.y, smoothTimeY);

		transform.position = new Vector3(posX, posY, transform.position.z);

		if (bounds)
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCamPos.x, maxCamPos.x),
				Mathf.Clamp(transform.position.y, minCamPos.y, maxCamPos.y),
				Mathf.Clamp(transform.position.z, minCamPos.z, maxCamPos.z));
		}
	}


}
