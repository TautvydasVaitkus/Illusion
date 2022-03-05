using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed = 3.0f;
    private Animation anim;
    Rigidbody m_Rigidbody;
    private Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        transform.position.Set(26, 0.5f, -65);
        anim = gameObject.GetComponent<Animation>();
        m_Rigidbody = GetComponent<Rigidbody>();
        timer = FindObjectOfType<Timer>();
        Debug.Log(timer.timeLeft);

    }

    // Update is called once per frame
    void Update()
    {

        /*if (timer.timeLeft >= 0)
        {
            anim.Play("Zombie|ZombieIdle");
        }*/  
        
            if (transform.position.z <= -44)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                anim.Play("Zombie|ZombieWalk");
            }                 
    }
}
