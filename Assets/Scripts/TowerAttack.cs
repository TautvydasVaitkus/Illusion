using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{

    public ZombieMove movingZombie;
    private float nextActionTime = -5f;
    public GameObject findZombie;
    public SpawnArmy zombieClones;
    private float minDist;
    private GameObject bestTarget;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        movingZombie = FindObjectOfType<ZombieMove>();
        findZombie = GameObject.Find("ZombieMenu");
        zombieClones = FindObjectOfType<SpawnArmy>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        minDist = 999;


        if (nextActionTime < 0f)
        {
            Debug.Log("SHOT");
            foreach (var cloneObj in zombieClones._clones)
            {
                if (transform.position.z - cloneObj.transform.position.z < 0.02f && transform.position.y - cloneObj.transform.position.y < 2)
                {
                    Destroy(cloneObj);
                }
            }
            nextActionTime = 5f;
        }
        else
        {
            nextActionTime -= Time.deltaTime;
        }
 
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(5f);
    }
}
