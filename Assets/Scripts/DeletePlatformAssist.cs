using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatformAssist : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name.StartsWith("Frog"))
        {
            if (Random.Range(1,15) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(enemyPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));
            }
        }

    }

}
