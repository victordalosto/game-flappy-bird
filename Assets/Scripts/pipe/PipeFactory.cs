using UnityEngine;

public class PipeFactory : MonoBehaviour
{

    public GameObject pipe;

    private float timer;
    private float spawnRate;
    private readonly float maxHeightOffsetBetweenPipes = 10;

    private float highestY;
    private float lowestY;


    void Start()
    {
        highestY = transform.position.y + maxHeightOffsetBetweenPipes;
        lowestY = transform.position.y - maxHeightOffsetBetweenPipes;
        SpawnPipe();
    }



    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
        }
    }



    private void SpawnPipe()
    {
        if (pipe == null)
        {
            return;
        }
        Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestY, highestY)), transform.rotation);
        spawnRate = UnityEngine.Random.Range(0.9f, 2.2f);
        timer = 0;
    }



    public void StopSpawning()
    {
        enabled = false;
    }

}
