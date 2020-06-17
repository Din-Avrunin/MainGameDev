using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallonSelection : MonoBehaviour
{
    [SerializeField] Sprite RedBalloon;
    [SerializeField] Sprite GreenBalloon;
    [SerializeField] Sprite YellowBalloon;
    [SerializeField] Sprite BlueBalloon;
    [SerializeField] Sprite PurpleBalloon;
    [SerializeField] Sprite ShieldBalloon;



    void Update()
    {
       
        int colorId = PlayerPrefs.GetInt("color");
        switch(colorId)
        {
            case 0:
                this.gameObject.GetComponent<Image>().sprite = RedBalloon;
                break;
            case 1:
                this.gameObject.GetComponent<Image>().sprite = GreenBalloon;
                break;
            case 2:
                this.gameObject.GetComponent<Image>().sprite = YellowBalloon;
                break;
            case 3:
                this.gameObject.GetComponent<Image>().sprite = BlueBalloon;
                break;
            case 4:
                this.gameObject.GetComponent<Image>().sprite = PurpleBalloon;
                break;
            case 5:
                this.gameObject.GetComponent<Image>().sprite = ShieldBalloon;
                break;
            default:
                this.gameObject.GetComponent<Image>().sprite = RedBalloon;
                break;

        }

        
    }
}
