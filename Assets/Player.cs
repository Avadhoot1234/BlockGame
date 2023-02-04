
using UnityEngine;


public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardforce=2000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce* Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(500*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
           rb.AddForce(-500*Time.deltaTime,0,0);
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<Gamemanager>().EndGame();
        }

    }
}
