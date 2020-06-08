using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartGame()//the first level is allways in scene number 3
    {
        SceneManager.LoadScene(3);
    }
    public void Mainmenu() {//the main menu is allways in scene number 0
        SceneManager.LoadScene(0);
    }
    public void Instructions(){//the instruction menu is allways in scene number 1
        SceneManager.LoadScene(1);
    }

}
