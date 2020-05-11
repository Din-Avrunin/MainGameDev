using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    private GameObject laser;
    [SerializeField]
    private float fire_time_rate = 0.25f;
    [SerializeField]
    private float next_fire = 0.0f;
    [SerializeField]
    private int life=3;
    [SerializeField]
    private GameObject _tripleShot;
    private bool _tripleShotActive = false;
    [SerializeField]
    private GameObject _explosion;
    [SerializeField]
    private AudioClip[] _sounds;
    private AudioSource _audioSource;
    [SerializeField]
    private int _score;
    [SerializeField]
    private UIManager _UImanager;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        transform.position = new Vector3(position.x, position.y, 0);
        _score = 0;
        _UImanager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Movment();
        Shoot();
    }

    private void Movment()
    {
       
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, vertical, 0) * _speed * Time.deltaTime);
        //add collider and trigger function
        if (Mathf.Abs(transform.position.x) > 12f)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
        if (Mathf.Abs(transform.position.y) > 7f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y*-1, transform.position.z);
        }
    }

    private void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&Time.time>next_fire)
        {
            next_fire = Time.time + fire_time_rate;
            if (!_tripleShotActive)
            {
                Vector3 laser_position = new Vector3(transform.position.x, transform.position.y + 1, 0);
                Instantiate(laser, laser_position, Quaternion.identity);
            }
            else
            {
                Vector3 laser_position = new Vector3(transform.position.x, transform.position.y + 9, 0);
                Instantiate(_tripleShot, laser_position, Quaternion.identity);
            }
        }
    }

    public void Damage()
    {
        life--;
        _UImanager.LifeScore(life);
        if(life<1)
        {
            StartCoroutine(Explosion());
            _UImanager.GameOverEnable();
        }
    }

    public void TripleShotActive()
    {
        _tripleShotActive = true;
        StartCoroutine(TripleShotRoutine());
    }

    public void AddScore()
    {
        _score+=10;
        _UImanager.ScoreView(_score);
    }

    IEnumerator TripleShotRoutine()
    {
        yield return new WaitForSeconds(5f);
        _tripleShotActive = false;
    }

    IEnumerator Explosion()
    {
        _explosion.SetActive(true);
        _speed = 0;
        yield return new WaitForSeconds(0.7f);
        Destroy(this.gameObject);
    }
}
