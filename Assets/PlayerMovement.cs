using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
  
    void Start()
    {
        //rb.AddForce(0, 500, 200);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
