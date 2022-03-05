using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulipka : MonoBehaviour
{
public float speed=5f;
public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir=target.position - this.transform.localPosition;
        float distThisFrame=speed*Time.deltaTime;
        if(dir.magnitude<=distThisFrame){
        DoBulletHit();
        }
        else{
        transform.Translate(dir.normalized*distThisFrame,Space.World);
        
        }
    }
    void DoBulletHit(){
    Destroy(gameObject);
    }
}
