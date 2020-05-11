using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private Text _score;
    [SerializeField]
    private GameObject GameOver;
    [SerializeField]
    private Text _restart;
    [SerializeField]
    private Text _pausing;
    [SerializeField]
    private Image[] _lives;

    void Start()
    {
        _restart.enabled = false;
        _pausing.enabled = false;

    }

    void Update()
    {

    }

    public void ScoreView(int Point)
    {
        _score.text = "" + Point;
    }
    public void LifeScore(int lives)
    {
        if (lives < 3)
        {
            _lives[lives].enabled = false;
        }
    }

    public void GameOverEnable()
    {
        StartCoroutine(GameOverRoutine());
    }
    IEnumerator GameOverRoutine()
    {
        yield return new WaitForSeconds(1.5f);
        FindObjectOfType<MyGameManager>().SetGameOver();
        _restart.enabled=true;
        _pausing.enabled=true;
        while (true)
        {
            GameOver.SetActive(true);
            yield return new WaitForSeconds(1f);
            GameOver.SetActive(false);
            yield return new WaitForSeconds(1f);
        }
    }
}
