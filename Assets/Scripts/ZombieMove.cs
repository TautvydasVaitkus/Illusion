using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed = 3.0f;
    private Animation anim;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        transform.position.Set(0, 0, -12);
        anim = gameObject.GetComponent<Animation>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z <= 6)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.Play("Zombie|ZombieWalk");
        }     
    }
}
