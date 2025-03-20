using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public Transform[] spawnPossitions;

    public float startTime = 2.5f;
    private float timeBetweenSpawns = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeBetweenSpawns = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBetweenSpawns <= 0f){
            Spawn();
            timeBetweenSpawns = startTime;
        }
        else {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }

    void Spawn() {
        int randomPoint = Random.Range(0, spawnPossitions.Length);
        Instantiate(pipePrefab, spawnPossitions[randomPoint].position, Quaternion.identity);
    }
}
