using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    int z = 0;
    [SerializeField]
    public float time = 4f;
    [SerializeField]
    private GameObject _enemyPrefabs;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private float up = 8f;
    [SerializeField]
    private float right = 0f;
    [SerializeField]
    private float left = 0f;
    [SerializeField]
    private float down = -8f;

    // Start is called before the first frame update 
    void Start()
    {
        StartCoroutine("SpawnEnemyRoutine");
    }


    IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {

            Vector3 postospawn = new Vector3(UnityEngine.Random.Range(left, right), UnityEngine.Random.Range(up, down), z);
            GameObject new_enemy = Instantiate(_enemyPrefabs, postospawn, _enemyPrefabs.gameObject.transform.rotation);
            new_enemy.transform.parent = _enemyContainer.transform;
            //if (time.time % 10 == 0)
            //{
            //    time /= 2;


            //}
            yield return new WaitForSeconds(time);
        }
    }
}