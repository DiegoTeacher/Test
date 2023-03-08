using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porteria : MonoBehaviour
{
   // public UpdateText updateText;
    public int playerIndex;
    public Animator animator;
    private AudioSource src;

    private void Start()
    {
        src = GetComponent<AudioSource>();    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Ball b = other.GetComponent<Ball>();

        if (b)
        {
            GameManager.instance.puntuaciones[playerIndex]++;
            //updateText?.Actualizar();
            b.StartMatch();
            animator.Play("VictoryAnim");
            src.Play();
        }

        // other.GetComponent<Ball>()?.StartMatch();
    }
}
