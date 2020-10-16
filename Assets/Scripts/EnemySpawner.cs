using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform leftSpawn01;
    public Transform leftSpawn02;
    public Transform rightSpawn01;
    public Transform rightSpawn02;

    public int choosenOne;

    public GameObject enemy;

    public Enemy_Ship enemyship;

        public void Update()
        {
        choseSpawn();
        spawn();
        }

        public void spawn()
        {

            if (choosenOne == 1)
            {
            GameObject newEnemy = Instantiate(enemy, leftSpawn01.transform);
            }

            if (choosenOne == 2)
            {
            GameObject newEnemy = Instantiate(enemy, leftSpawn02.transform);
            }

            if (choosenOne == 3)
            {
            GameObject newEnemy = Instantiate(enemy, rightSpawn01.transform);
            }

            if (choosenOne == 4)
            {
            GameObject newEnemy = Instantiate(enemy, rightSpawn02.transform);
            }
        }

        public void choseSpawn()
        {
        choosenOne = Random.Range(1, 5);

        }
}
