using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 8f;
    private float countDown = 3f;
    private int waveNumber = 0;
    public Transform spawnPoint;

    public Text waveCountdownText;

    private void Update()
    {
        // Update code
        if (countDown <= 0f)
        {
            // Spawn enemies
            StartCoroutine(spawnWave());
            countDown = timeBetweenWaves;
        }

        countDown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Ceil(countDown).ToString();
    }

    IEnumerator spawnWave()
    {
        waveNumber++;
        Debug.Log("Wave Incoming!");
        for (int i = 0; i < waveNumber; i++)
        {
            // Spawn an enemy
            spawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void spawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
