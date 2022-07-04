using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StickmanController : MonoBehaviour
{
    private Rigidbody2D rb;    
    [SerializeField] private float moveSpeed=10.0f;
    [SerializeField] private float[] xBoundarys;
    [SerializeField] GameObject scoreObject;
    GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        StickmanMove();
    }

    private void StickmanMove()
    {        
        if (Input.GetMouseButtonDown(0) && MousePosition().x > xBoundarys[0] && MousePosition().x < xBoundarys[1])
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
    }     

    private Vector3 MousePosition()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, transform.position.y, transform.position.z));
        return mousePos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            moveSpeed *= -1.0f;
            transform.Rotate(0, 180, 0);
        }      

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.CompareTag("Score"))
        {
            gameManager.UpScore();
        }
    }
}
