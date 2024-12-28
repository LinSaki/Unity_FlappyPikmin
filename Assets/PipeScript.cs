using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    private float outZone = -31;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < outZone)
        {
            Debug.Log("Deleted Pipe");
            Destroy(gameObject);
        }
    }
}
