using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigScript : MonoBehaviour
{
    public GameOverScreen GameOverScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.StartsWith("Player"))
        {
            GameOverScreen.Setup();
        }
    }
}
