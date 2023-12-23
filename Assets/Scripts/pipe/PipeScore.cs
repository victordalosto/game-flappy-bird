using UnityEngine;


public class PipeMiddleScript : MonoBehaviour
{
    private Score score;
    private Bird bird;
    private bool hasScored = false;


    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<Bird>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bird" && !hasScored && bird.isAlive)
        {
            hasScored = true;
            score.IncreaseScore(1);
        }
    }

}
