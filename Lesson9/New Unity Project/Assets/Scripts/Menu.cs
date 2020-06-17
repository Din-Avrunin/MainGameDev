using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void restart() {
        Time.timeScale = 1f;
        //GameObject.Find("Data").GetComponent<Data>().setScore(0);
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("color", 0);
        PlayerPrefs.SetInt("prevcolor", 0);
        PlayerPrefs.SetInt("activeShield", 0);
        PlayerPrefs.SetInt("life", 5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        
    }
    public void StartGame()//the first level is allways in scene number 2
    {
        //GameObject.Find("Data").GetComponent<Data>().setScore(0);
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("life", 5);
        PlayerPrefs.SetInt("color", 0);
        PlayerPrefs.SetInt("prevcolor", 0);
        PlayerPrefs.SetInt("activeShield", 0);
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    public void Mainmenu() {//the main menu is allways in scene number 0
        //Destroy(GameObject.Find("Data"));
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("life", 5);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Instructions(){//the instruction menu is allways in scene number 1
        //GameObject.Find("Data").GetComponent<Data>().setScore(0);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }


}
