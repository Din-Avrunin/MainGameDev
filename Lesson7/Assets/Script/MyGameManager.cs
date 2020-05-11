using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour
{
    [SerializeField]
    private bool _GameOver = false;



    void Start()
    {
        
        
    }
    public void SetGameOver()
    {
        _GameOver = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _GameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
