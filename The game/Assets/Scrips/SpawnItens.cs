using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItens : MonoBehaviour
{
    public GameObject[] SpawnItems;

    private int random;

    public float spawnTime;

    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void SpawnRandom()
    {
        random = Random.Range(0, SpawnItems.Length);
        Instantiate(SpawnItems[random], transform.position, transform.rotation);
        GameObject.FindObjectOfType<GameManager>().AtualizarMoedas();
    }
}
