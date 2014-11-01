
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	public Transform Head;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	
	void LateUpdate()
	{
		if(Input.GetKey("up"))
		{
			transform.position += new Vector3(0f, 0f, 10f * Time.deltaTime);
		}
		if(Input.GetKey("down"))
		{
			transform.position -= new Vector3(0f, 0f, 10f * Time.deltaTime);
		}
		if(Input.GetKey("right"))
		{
			transform.position += new Vector3(12f * Time.deltaTime, 0f, 0f);
		}
		if(Input.GetKey("left"))
		{
			transform.position -= new Vector3(12f * Time.deltaTime, 0f, 0f);
		}
	}
}