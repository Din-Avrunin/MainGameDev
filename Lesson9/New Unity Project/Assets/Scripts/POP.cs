using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POP : MonoBehaviour
{
    [SerializeField] GameManager GameManager;
    [SerializeField]int shieldValue = 5;
    int shield = 0;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") {
            if (shield == 0)
            {
                GameManager.fail();
                Destroy(this.gameObject);
            }
            else shield--;
            if (shield == 0) {
                PlayerPrefs.SetInt("color", PlayerPrefs.GetInt("prevcolor"));
                PlayerPrefs.SetInt("activeShield", 0);
            }
        }
    }

    public void shieldUP() {
        shield = shieldValue;
    }
}
