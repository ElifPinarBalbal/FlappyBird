using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // Di�er component'larla ileti�im kurabilmek i�in onlar� reference etmemiz laz�m!
    public Rigidbody2D myRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Codes in Start will run as soon as the script is enabled!
    // Runs only once
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update runs constantly while the script is enabled.

    void Update()
    {
        // Check whether the Space is pressed
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.linearVelocity = Vector2.up * 10;
        }
    }
}
