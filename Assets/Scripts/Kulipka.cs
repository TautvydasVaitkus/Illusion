using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulipka : MonoBehaviour
{
public float speed=5f;
public Transform target;
    public float greitis =  70f;
    // Start is called before the first frame update
   
    public void Seek(Transform _target)
    {
        target = _target;
    }
    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
        }
        Vector3 dir = target.position - transform.position;
        float distanceframe = speed * Time.deltaTime;
        if(dir.magnitude <= distanceframe)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceframe, Space.World);
    }
    void HitTarget()
    {
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
