using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
    public GameObject[] tilePrefabs;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float length = 10.0f;
    private float safeZone = 15.0f;
    private int amnTilesOnScreen = 10;
    private int lastIndex = 0;
    private List<GameObject> activeTiles;


    // Use this for initialization
    void Start() {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            if(i < 7)
               SpawnTile(0);
            else
                SpawnTile();
        }
    }

	// Update is called once per frame
	void Update () {
        if( (playerTransform.position.z - safeZone) > (spawnZ - amnTilesOnScreen * length))
        {
            SpawnTile();
            DeleteTile();
        }

	}

    private void SpawnTile (int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(tilePrefabs[RandomPrefab()]) as GameObject;
        else
            go = Instantiate(tilePrefabs[prefabIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += length;
        activeTiles.Add(go);
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefab()
    {
        if (tilePrefabs.Length <= 1)
        {
            return 0;
        }

        int randomIndex = lastIndex;
        while( randomIndex == lastIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }
        lastIndex = randomIndex;
        return randomIndex;
    }
}
