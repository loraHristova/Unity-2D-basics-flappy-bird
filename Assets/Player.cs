using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text currentScoreText;
    public float jumpHeight = 5f;
    public Rigidbody2D rb;
    public int currentScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 4.46f){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

       if (Input.GetKey(KeyCode.Space)) {
        Jump();
       } 

       currentScoreText.text = currentScore.ToString();
    }

    void Jump() {
        Vector2 velocity = rb.linearVelocity;
        velocity.y = jumpHeight;
        rb.linearVelocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score") {
            currentScore += 1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Pipe") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
