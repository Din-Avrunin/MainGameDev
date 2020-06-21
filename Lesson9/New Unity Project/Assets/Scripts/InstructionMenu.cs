using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionMenu : MonoBehaviour
{

    [SerializeField] GameObject instru1;
    [SerializeField] GameObject instru2;
    [SerializeField] GameObject instru3;



    void Start()
    {


    }

        // Start is called before the first frame update
        void Update()
    {
        int currentPage = PlayerPrefs.GetInt("instru");


        switch (currentPage)
        {
            case 1:
                instru1.SetActive(true);
                instru2.SetActive(false);
                instru3.SetActive(false);
                break;
            case 2:
                instru1.SetActive(false);
                instru2.SetActive(true);
                instru3.SetActive(false);
                break;
            case 3:
                instru1.SetActive(false);
                instru2.SetActive(false);
                instru3.SetActive(true);
                break;
        }

        
    }


    public void nextPage()
    {
        PlayerPrefs.SetInt("instru", PlayerPrefs.GetInt("instru") + 1);
    }

    public void prevPage()
    {
        PlayerPrefs.SetInt("instru", PlayerPrefs.GetInt("instru") - 1);
    }

}
