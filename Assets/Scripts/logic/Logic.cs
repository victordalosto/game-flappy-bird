using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Logic : MonoBehaviour
{

    private Bird bird;
    public PipeFactory pipeFactory;

    public GameObject gameOverPanel;

    public float moveSpeed { get; private set; } = 6f;
    private float timer = 0f;



    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<Bird>();
        pipeFactory = GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeFactory>();
    }



    void Update()
    {
        if (!bird.isAlive)
        {
            endGame();
        }


        if (timer >= 1f && bird.isAlive)
        {
            moveSpeed += 1;
            timer = 0;
        }
        timer += Time.deltaTime;
    }



    public void endGame()
    {
        pipeFactory.StopSpawning();
        StartCoroutine(DecreaseSpeedGraduallyToZero());
        gameOverPanel.SetActive(true);
    }



    private IEnumerator DecreaseSpeedGraduallyToZero()
    {
        float timeToDecrease = 1f;
        float startSpeed = moveSpeed;

        float elapsedTime = 0f;

        while (elapsedTime <= timeToDecrease)
        {
            moveSpeed = Mathf.Lerp(startSpeed, 0f, elapsedTime / timeToDecrease);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        moveSpeed = 0f;
    }



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
