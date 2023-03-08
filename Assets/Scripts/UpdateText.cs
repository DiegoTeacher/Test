using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    public TMPro.TMP_Text texto;
    public int playerIndex;

    public void Update()
    {
        texto.text = GameManager.instance.puntuaciones[playerIndex].ToString();
    }
}
