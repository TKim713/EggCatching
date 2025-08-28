using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    public float spawnInterval = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnFruit();
            timer = 0f;
        }
    }

    void SpawnFruit()
    {
        int index = Random.Range(0, fruitPrefabs.Length);
        GameObject fruitPrefab = fruitPrefabs[index];

        float x = Random.Range(-7f, 7f);
        Vector2 spawnPos = new Vector2(x, transform.position.y);

        Instantiate(fruitPrefab, spawnPos, Quaternion.identity);
    }
}
