using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class RandomEnemy : MonoBehaviour
    {     
        public GameObject block;                
        public float xMin, xMax, yMin, yMax;        

        void Start ()
        {
            Spawn();
            StartCoroutine(SpawnBlock());
        }
        void Spawn ()
        {
            int spawnEnemy = Random.Range (7, 14);
            for (int i =0; i < spawnEnemy; i++)
            {
                float randomX = Random.Range(xMin, xMax);
                float randomY = Random.Range(yMin, yMax);
                Instantiate(block, new Vector2(randomX, randomY), Quaternion.identity);
            }           
        }
        IEnumerator SpawnBlock()
        {
            if (transform.childCount < 12)
            {
                float randomX = Random.Range(xMin, xMax);
                float randomY = Random.Range(yMin, yMax);
                Instantiate(block, new Vector2(randomX, randomY), Quaternion.identity);
            }
            yield return new WaitForSeconds(3);
            StartCoroutine(SpawnBlock());
        }
    }
