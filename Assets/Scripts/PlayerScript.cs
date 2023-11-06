using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerScript : MonoBehaviour
{
    public float movementSpeed = 10f;
    float movement = 0f;
    Rigidbody2D rb;
    private float topScore = 0.0f;
    public TextMeshProUGUI scoreText;
    public GameObject pauseMenuUI;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if(rb.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
    
        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void FixedUpdate()
    {
        movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movement * movementSpeed, rb.velocity.y);
        
    }
    
}
