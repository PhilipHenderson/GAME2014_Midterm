using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Range(1, 4)]
    public int enemyNumber = 3;
    
    private List<GameObject> enemyList;
    private GameObject enemyPrefab;
    public Vector3 enemyY;

    // Start is called before the first frame update
    void Start()
    {
        enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
        BuildEnemyList();
        enemyY = new Vector3(0.0f, 9.0f, 0.0f);
    }


    public void BuildEnemyList()
    {
        enemyList = new List<GameObject>();

        for (var i = 0; i < enemyNumber; i++)
        {
            var enemy = Instantiate(enemyPrefab, enemyY, Quaternion.identity);
            enemyList.Add(enemy);
        }
    }
}
