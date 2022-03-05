using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{

    public ZombieMove movingZombie;

    // Start is called before the first frame update
    void Start()
    {
        movingZombie = FindObjectOfType<ZombieMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z - movingZombie.transform.position.z < 2)
        {
            Destroy(movingZombie.gameObject);

        }
    }
}
