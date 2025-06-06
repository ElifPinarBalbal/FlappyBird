using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // Di�er component'larla ileti�im kurabilmek i�in onlar� reference etmemiz laz�m!
    public Rigidbody2D myRigidBody;

    public float flapStrength; // Unity'de b�yle bir field create'lemi� olduk!

    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Codes in Start will run as soon as the script is enabled!
    // Runs only once
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    // Update runs constantly while the script is enabled.

    void Update()
    {
        // Check whether the Space is pressed
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
