using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 20f;

    float movement = 0f;
    Rigidbody2D rb;

    int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.acceleration.x * movementSpeed;
    }

    void FixedUpdate() 
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("CoinCheck")) 
        {            
            Destroy(other.gameObject);
            ScoreUp();
        } else if (other.gameObject.CompareTag("FallCheck"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void ScoreUp() {
        score++;
        scoreText.text = "X" + score.ToString();
    }

}
