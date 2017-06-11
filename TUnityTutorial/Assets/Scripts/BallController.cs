using UnityEngine;

public class BallController : MonoBehaviour
{
	public float speed;
	
	void OnCollisionEnter (Collision obj){
		if (obj.gameObject.CompareTag("Gameover")) {
			GameObject.Instantiate (this.gameObject, new Vector3 (0, 3, 0), Quaternion.identity);//新しく生成
			Destroy (this.gameObject);	//自身を破棄
		}
	}

	void Start () 
	{
		var rb = GetComponent<Rigidbody> ();
        rb.AddForce ((transform.forward + transform.right + transform.up) * speed,	ForceMode.VelocityChange);
	}
}
