using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArmy : MonoBehaviour
{
    public GameObject zombie;
    public GameObject money;
    public GameObject timer;
    private bool spawned = false;
    public GameObject count;

    public void Start()
    {
        spawned = false;
    }
    public void Update()
    {
        if (timer.GetComponent<Timer>().timeLeft <= 0 && spawned == false)
            {
            Spawn();
            spawned = true;

        }
    }
    public void Spawn()
    {
        for (int i = 1; i <= count.GetComponent<Spawner>().SpawnCounter; i++)
        {
            var position = new Vector3(Random.Range(26, 27.5f), 0.5f, Random.Range(-65.5f, -65));
            StartCoroutine("wait");
            Instantiate(zombie, position, Quaternion.identity);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
    }
}
