using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
 float range =2f;
 public  GameObject kulipka;
 float fireCooldown=1f;
 float fireCooldownLeft=0;
 //public GameObject kulipka;
    public GameObject movingZombie;
    //private Vaector3 kulipkos;
    // Start is called before the first frame update
    private void Awake(){
    kulipka.transform.position=transform.Find("Kulipkos").position;
    }
    void Start()
    {
        movingZombie = FindObjectOfType<ZombieMove>();
        kulipka=FindObjectOfType<Kulipka>();
    }

    // Update is called once per frame
    void Update()
    {
    GameObject[] zombies=GameObject.FindObjectOfType<ZombieMove>();
    GameObject nearestZombie=null;
    foreach(GameObject e in zombies){
    float d = Vector3.Distance(this.transform.position,e.transform.position);
        if (nearestZombie == null || d<range)
        {
        nearestZombie=e;
            //dist=d;
        }
        }
        fireCooldownLeft-=Time.deltaTime;
        if(fireCooldownLeft <=0){
        Shoot(nearestZombie);
        }
        void Shoot(GameObject e){
        fireCooldownLeft=fireCooldown;
        GameObject bulletGO=(GameObject)Instantiate(kulipka,this.transform);
        kulipka.transform.position = new Vector3(-0.93f, 0.3f, -0.0f);
        }

    }
}
