using System.Collections;
using UnityEngine;

public class RacketController : MonoBehaviour
{
	public float speed;
	
	void FixedUpdate ()
	{
		MouseInputDir.Flick ();
		
		switch (MouseInputDir.dir)
		{
			case "a":
				StartCoroutine("Swing", 100);
				break;
			case "e":
				StartCoroutine("Swing", -100);
				break;
		}
		

		if (Input.GetKey (KeyCode.W))
		{
			this.transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.A))
		{
			this.transform.position += Vector3.left * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S))
		{
			this.transform.position += Vector3.down * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.D))
		{
			this.transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
	
	IEnumerator Swing (int speed)
	{
		do 
		{
			this.transform.RotateAround(transform.position, Vector3.up, speed * Time.deltaTime);
			yield return null;
		} while (this.transform.rotation.y > -0.40f && this.transform.rotation.y < 0.40f);
		this.transform.rotation = Quaternion.Euler (Vector3.zero);
	}
}
