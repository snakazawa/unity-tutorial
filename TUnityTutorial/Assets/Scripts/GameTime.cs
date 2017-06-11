using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{

	public Text text;
	private float time;
	

	void Start ()
	{
		time = 0.0f;
		text.text = time.ToString();
	}
	
	void Update ()
	{
		time += Time.deltaTime;
		text.text = time.ToString();
	}
}
