using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        var rb = GetComponent<Rigidbody>();
        rb.AddForce(x * speed, 0, z * speed);
    }
}
