using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    private float startDelay = 0.1f;
    private float spawnInterval;

    public Collider[] neighbours;

    public Vector3 newPos;

    void Start(){
        Invoke("SpawnFoodItem", startDelay);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void SpawnFoodItem()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-20,20), 1, Random.Range(-20,20));
        Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        //spawnInterval = Random.Range(3, 5);
        Invoke("SpawnFoodItem", startDelay);
    }

    Vector3 FindNewPos() {
        //neighbours = [];
        do {
            // draw a new position
            newPos = new Vector3(Random.Range(-20,20), 1, Random.Range(-20,20));
            // get neighbours inside minDistance:
            neighbours = Physics.OverlapSphere(newPos, 5);
            // if there's any neighbour inside range, repeat the loop:
        } while (neighbours.Length > 0);
        return newPos; // otherwise return the new position
    }
}
