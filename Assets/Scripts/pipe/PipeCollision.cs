using UnityEngine;


public class PipeCollisionScript : MonoBehaviour
{
    private Score score;


    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bird")
        {
            score.DecreaseScore(3);
        }
    }

}
