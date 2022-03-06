using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
 float range =3f;
 public  GameObject kulipka;
 public Transform firepoint;
    public Transform target;
 public float firerate = 3f;
    float firecountdown = 0f;
 //public GameObject kulipka;
    public GameObject movingZombie;
    //private Vaector3 kulipkos;
    // Start is called before the first frame update
    private void Awake(){
    //kulipka.transform.position=transform.Find("Kulipkos").position;
    }
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");
        float shortest = Mathf.Infinity;
        GameObject nearest = null;
        foreach (GameObject enemy in enemies)
        {
            float distancetoenemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distancetoenemy < shortest)
            {
                shortest = distancetoenemy;
                nearest = enemy;
            }
        }
        if (nearest != null && shortest <= range)
        {
            target = nearest.transform;
        }
        else{
            target = null;
        }
    }
    // Update is called once per frame
    public void Update()
    {
        if(firecountdown <= 0f)
        {
            Shoot();
            firecountdown = 1f / firerate; 
        }
        firecountdown -= Time.deltaTime;
    }
    void Shoot()
    {
       GameObject go = (GameObject)Instantiate(kulipka, firepoint.position, firepoint.rotation);
        Kulipka bullet = kulipka.GetComponent<Kulipka>();
        if(bullet != null)
        {
            bullet.Seek(target);
        }
    }
}
