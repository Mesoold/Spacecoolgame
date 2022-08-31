using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayertoController : MonoBehaviour
{
    public float Speed;
    
    int score = 0;

    public Text ScoreText;
    
    void Start()
    {
        Debug.Log("Hello world");
        Debug.Log("This objest position is : " + transform.position);
        Debug.Log("This objest rotation is : " + transform.rotation);
        Debug.Log("This objest scale is : " + transform.localScale);
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-transform.right * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * Speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Hit " + collision);
        collision.gameObject.SetActive(false);

        if(collision.gameObject.tag == "Bomb")
        {
            gameObject.SetActive(false);
            ScoreText.text = "Game over";
        }
        else
        {
            score += 1;
            ScoreText.text = "Score : " + score;
            collision.gameObject.SetActive(false);
        }

    }
}
