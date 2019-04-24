using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSizeZ;
	private bool faster;

	private Vector3 startPosition;

	void Start ()
	{
		faster = false;
		startPosition = transform.position;
	}


	void Update ()
	{
			if (Input.GetKeyDown(KeyCode.T))
		{
		faster = true;
		}
		if(faster)
		{
			if (scrollSpeed > -16)
			scrollSpeed -= Time.deltaTime;
		}
		
		
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
		transform.position = startPosition + Vector3.forward * newPosition;
	}
}