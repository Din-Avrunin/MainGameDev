using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePlayerBallon : MonoBehaviour
{
    [SerializeField] Sprite RedBalloon;
    [SerializeField] Sprite GreenBalloon;
    [SerializeField] Sprite YellowBalloon;
    [SerializeField] Sprite BlueBalloon;
    [SerializeField] Sprite PurpleBalloon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        int colorId = PlayerPrefs.GetInt("color");
        switch (colorId)
        {
            case 0:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RedBalloon;
                break;
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = GreenBalloon;
                break;
            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = YellowBalloon;
                break;
            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BlueBalloon;
                break;
            case 4:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = PurpleBalloon;
                break;
            default:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RedBalloon;
                break;

        }

    }
}
