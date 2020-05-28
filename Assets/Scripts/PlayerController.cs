using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float playerJumpForcce = 20f;
    public float playerSpeed = 5f;

    private Rigidbody2D myRigibody2D;

    private GameManager gameManager;
    void Start()
    {
        myRigibody2D = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myRigibody2D.velocity = new Vector2(myRigibody2D.velocity.x, playerJumpForcce);
        }

        myRigibody2D.velocity = new Vector2(playerSpeed, myRigibody2D.velocity.y);
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            gameManager.AddScore();
        }
        else if(collision.CompareTag("BadItem") || collision.CompareTag("DeathZone"))
        {
            Destroy(collision.gameObject);
            PlayerDead();
        }
        else if ( collision.CompareTag("DeathZone"))
        {
            PlayerDead();
        }

    }

    void PlayerDead()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
