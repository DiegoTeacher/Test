using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// hola
public class Ball : MonoBehaviour
{
    private float initialSpeed;
    public float speed;

    private Vector2 dir;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        initialSpeed = speed;
        StartMatch();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = dir * speed;
    }

    Vector2 SelectDir()
    {
        return new Vector2(Random.Range(-1, 2), Random.Range(-1, 2));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        dir.y *= -1;
        
        if(other.gameObject.GetComponent<PalaMovement>())
        {
            dir.x *= -1;
            dir.y = Random.Range(-1, 2);
            speed *= 1.1f;
        }
    }

    public void StartMatch()
    {
        transform.position = Vector3.zero;

        do
        {
            dir = SelectDir();
        } while (dir.x == 0);
        speed = initialSpeed;
        Debug.Log("START!");
    }
}
