using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Spawner variables
    //reference to prefab 
    public GameObject prefab;
    //how often spawn
    public float spawnRate = 1f; //seconds
    //change position of the pipe - range - min and max where it will spawn
    public float minHeight = -1f;
    // Start is called before the first frame update
    public float maxHeight = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //invoke - repeating - allows to disable spawner - if player loses
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    //cancel spawn
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        //clone prefab
        //Quaternion.identity - no rotation at all 
        GameObject needles = Instantiate(prefab, transform.position, Quaternion.identity); //allows us create new object - clone
        needles.transform.position += Vector3.up;
        //needles.transform.position += Vector3.up * Random.Range(minHeight, maxHeight); //used to spawn needles up/down - make it harder for player
        //0.75 - scale

    }
}
