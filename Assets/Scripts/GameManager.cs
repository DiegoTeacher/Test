using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // public TMPro.TMP_Text TMP;
    public int[] puntuaciones = new int[2];

    private void Awake()
    {
        if(!instance)
        {
            // si no tiene nada / la primera vez que se crea un game manager
            instance = this;
            DontDestroyOnLoad(gameObject); // si cambiamos de escena, el objeto NO se destruye
        }
        else
        {
            // instance tiene cosas, el game manager ya existe
            Destroy(gameObject);
        }
    }

}
