using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierManager : MonoBehaviour
{
    public GameObject RedBarrierPrefab;
    public GameObject BlueBarrierPrefab;
    public GameObject WallPrefab;

    public float TimeNextWallSpawn = 0;

    private Vector2 SpawnRegion;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRegion = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeNextWallSpawn)
        {
            SpawnWall();

            TimeNextWallSpawn = Time.time + Settings.WallIntervalSpeed;
        }
    }

    void SpawnWall()
    {
        Vector3 spawnPosition = new Vector3(
                0,
                Random.Range(-SpawnRegion.y, SpawnRegion.y),
                0
            );

        Vector3 wallPos = new Vector3(0, 6f, 0);

        GameObject wallAbove = Instantiate(WallPrefab, this.transform.position + spawnPosition - wallPos, Quaternion.identity);
        GameObject barrier = null;
        if (Random.Range(0f, 1f) >= 0.5f)
        {
            barrier = Instantiate(RedBarrierPrefab, this.transform.position + spawnPosition, Quaternion.identity);
        }
        else
        {
            barrier = Instantiate(BlueBarrierPrefab, this.transform.position + spawnPosition, Quaternion.identity);
        }
        GameObject wallBelow = Instantiate(WallPrefab, this.transform.position + spawnPosition + wallPos, Quaternion.identity);

        wallAbove.transform.localScale = new Vector3(1, 10, 1);
        barrier.transform.localScale = new Vector3(1, 2, 1);
        wallBelow.transform.localScale = new Vector3(1, 10, 1);
    }
}
