using UnityEngine;

// PREFABRICATED: new pipes spawned

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2; //How many seconds it should be between spawns
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();   // Initially a pipe created once
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;  // count the timer up!
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

        
    }

    void spawnPipe()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
