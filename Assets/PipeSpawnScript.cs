using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float offsetY = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) // then increase timer
        {
            timer += Time.deltaTime; //delTime =  counts every frame and works with whatever your pc's frame rate is
        }
        else // spawn pipe and restart timer
        {
            spawnPipe();
            timer = 0;
        }
        
    }
    // Spawn pipe
    void spawnPipe()
    {
        float minHeight = transform.position.y - offsetY;
        float maxHeight = transform.position.y + offsetY;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0), transform.rotation);
    }
}
