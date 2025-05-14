using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float startDelay = 2;
    private float repeatRate= 2f;
    private int bombObject;
    private PlayerControllerX playerControllerXScript;
    private Vector3 spawnPos = new Vector3(40, 13, 0);

    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", startDelay, repeatRate);
        playerControllerXScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
        bombObject = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (playerControllerXScript.gameOver == false)
        {
            Instantiate(objectPrefabs[bombObject], spawnPos, objectPrefabs[bombObject].transform.rotation);
        }

    }
}
