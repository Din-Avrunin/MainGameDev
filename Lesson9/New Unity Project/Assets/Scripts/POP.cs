using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POP : MonoBehaviour
{
    [SerializeField] GameManager GameManager;
    [SerializeField]int shieldValue = 5;
    int shield = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("shield", 0);   
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "cat") {
            if (shield == 0)
            {
                GameManager.fail();
                Destroy(this.gameObject);
            }
            else
            {

                shield--;
                PlayerPrefs.SetInt("shield", shield);
            }
            if (shield == 0) {
                PlayerPrefs.SetInt("color", PlayerPrefs.GetInt("prevcolor"));
                PlayerPrefs.SetInt("activeShield", 0);
            }
        }
    }

    public void shieldUP() {
        PlayerPrefs.SetInt("shield", shieldValue);
        shield = shieldValue;
    }
}
