using UnityEngine;

public class PipeScript : MonoBehaviour
{

    private Logic logic;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }



    void FixedUpdate()
    {
        transform.Translate(Vector3.left * logic.moveSpeed * Time.deltaTime);
        if (transform.position.x < -50)
        {
            Destroy(gameObject);
        }
    }

}
