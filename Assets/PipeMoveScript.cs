using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5; // default 5
    public float deadZone = -45; // for pipes that are no longer visible

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;  // Bilgisayardan bilgisayara speed'in deðiþmemesi için :)
        
        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
