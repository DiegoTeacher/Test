using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMovement : MonoBehaviour
{
    public float speed;
    public KeyCode upKey, downKey;
    private Rigidbody2D rb;
    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.zero;
        if (Input.GetKey(upKey)) // personalizar teclas
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0)); // simular velocidad
        }
        else if (Input.GetKey(downKey))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }

        // transform.Translate(new Vector3(0, speed * Time.deltaTime * Input.GetAxisRaw("Vertical"), 0));

        // Debug.Log("axis raw: " + Input.GetAxisRaw("Horizontal"));
    }
}
