using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float HeightRange = 0.5f;

    public float MaxTime = 1.75f;

    private float timer;
    void Start()
    {
        SpawnPipe();
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > MaxTime)
        {
            SpawnPipe();
            timer = 0;
        }
    }

    public void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-HeightRange, HeightRange));

        GameObject newPipe;

        newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        Destroy(newPipe, 15f);
    }
}
