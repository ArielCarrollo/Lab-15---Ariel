using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameManagerControl Gmc;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateEnemy", 2);
    }

    // Update is called once per frame

    void CreateEnemy()
    {
        GameObject enemy = Instantiate(EnemyPrefab, new Vector3(Random.Range(-9.60f, 8.70f), 4.55f, 0), transform.rotation);
        enemy.GetComponent<Explote>().SetGamemanager(Gmc);
        Invoke("CreateEnemy", 2);
    }
}
