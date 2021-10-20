using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;

    public static int Score;
    public GameObject ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        ScoreText.GetComponent<Text>().text = "Score: " + Score;

        if (Score >= 20)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    //Retry Button
    public void RetryButton()
    {
        Score = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
