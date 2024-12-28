using UnityEngine;

public class PipeTriggerScript : MonoBehaviour
{
    public LogicScript logicScript; //reference to user functions

    // create communication between Trigger and LogicScript
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //connect Tag of 'Logic Manager' to grab component 'LogicScript.cs' to Trigger
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == 3) && (logicScript.gameOverDisplay.activeSelf == false)) // check if pikmin actually went through the trigger
        {
            logicScript.increaseScore(1);
        }
        
    }
}
