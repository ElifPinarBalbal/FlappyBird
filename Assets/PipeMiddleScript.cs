using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Runs first when the object hits the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3) // eðer çarpan þey bird ise artýrýyoruz
        {
            logic.addScore(1);
        }
    }
}
