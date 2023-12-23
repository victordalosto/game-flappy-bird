using UnityEngine;

public class Bird : MonoBehaviour
{

    public new Rigidbody2D rigidbody;
    private Score score;

    public bool isAlive {get; private set;}

    private float flapStrenght;



    void Start()
    {
        isAlive = true;
        flapStrenght = 12f;
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        gameObject.name = "Bird";
    }



    void Update()
    {
        if (isAlive && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (transform.position.y < -30)
        {
            Die();
        }
    }



    private void Jump()
    {
        rigidbody.velocity = Vector2.up * flapStrenght;
    }



    public void Die()
    {
        isAlive = false;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            score.DecreaseScore(3);
        }
    }

}
