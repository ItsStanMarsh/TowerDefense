using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    List<GameObject> enemys = new List<GameObject>();

    public void Start()
    {
        Invoke("Spawn", 5f);
    }

    public void Spawn()
    {
        var instenemy =  Instantiate(enemy, new Vector3(8, 0.5f, Random.Range(0,3)), Quaternion.identity);

        enemys.Add(instenemy);
                
        Invoke("Spawn", 3);
    }

}
