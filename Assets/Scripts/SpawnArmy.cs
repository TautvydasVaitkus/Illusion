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
    public List<GameObject> _clones = new List<GameObject>();

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
        StartCoroutine("wait");
    }
    IEnumerator wait()
    {
        for (int i = 1; i <= count.GetComponent<Spawner>().SpawnCounter; i++)
        {
            var position = new Vector3(Random.Range(26, 27.5f), 0.5f, Random.Range(-65.5f, -65));
            yield return new WaitForSecondsRealtime(Random.Range(0f, 1f));
            var clone = Instantiate(zombie, position, Quaternion.identity);
            _clones.Add(clone);
        }

    }
}
