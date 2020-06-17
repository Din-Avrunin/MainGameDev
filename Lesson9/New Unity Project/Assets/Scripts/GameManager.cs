using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject levelFailUi;
    [SerializeField] GameObject BallonSelectionUI;
    [SerializeField] ScoreManager sm;
    [SerializeField] bool GameIsPaused = false;

    //GameObject data;
    //Data data2;
    public void Start()
    {
        //data = GameObject.Find("Data");
        //data2 = data.GetComponent<Data>();

        //int lives = data2.getLives();
        int lives = PlayerPrefs.GetInt("life");

        if (lives < 5)
        {
            GameObject.Find("Life 5").SetActive(false);
        }
        if (lives < 4)
        {
            GameObject.Find("Life 4").SetActive(false);
        }
        if (lives < 3)
        {
            GameObject.Find("Life 3").SetActive(false);
        }
        if (lives < 2)
        {
            GameObject.Find("Life 2").SetActive(false);
        }
        /*
        if (lives < 1)
        {
            GameObject.Find("Life 1").SetActive(false);
        }
        */

    }


    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("score"));


        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                PickBalloon();
            }
        }


    }

    public void fail()
    {
        //data2.setLives(data2.getLives() - 1);
        //DontDestroyOnLoad(ScoreManager);

        int life = PlayerPrefs.GetInt("life");
        life --; 

        if (life <= 0)
        {
            //GameObject.Find("Data").GetComponent<Data>().setScore(0);
            //data2.setLives(5);

            PlayerPrefs.SetInt("score", 0);
            GameObject.Find("Life 1").SetActive(false);
            sm.resetScore();
            Time.timeScale = 0f;
            levelFailUi.SetActive(true);
            
        }
        else
        {
            //GameObject.Find("Data").GetComponent<Data>().setScore(0);
            PlayerPrefs.SetInt("life", life);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void win() {
        SceneManager.LoadScene(2);
    }



    private void PickBalloon()
    {
        BallonSelectionUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        BallonSelectionUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

}
