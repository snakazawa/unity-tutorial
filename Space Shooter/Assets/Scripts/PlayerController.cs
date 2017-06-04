using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;
    
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        var rb = GetComponent<Rigidbody>();
        rb.velocity = movement * speed;

        var pos = rb.position;
        
        rb.position = new Vector3
        (
            Mathf.Clamp(pos.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(pos.z, boundary.zMin, boundary.zMax)
        );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
