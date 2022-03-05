using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed = 3.0f;
    public Animation anim;
    Rigidbody m_Rigidbody;
    private Timer timer;
  
    public int speedanim = 1;
    // Start is called before the first frame update
    public void Start()
    {
        transform.position.Set(26, 0.5f, -65);
        anim = gameObject.GetComponent<Animation>();
        m_Rigidbody = GetComponent<Rigidbody>();
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (timer.timeLeft >= 0)
        {
            anim.Play("Zombie|ZombieIdle");
        }  
        
        if (timer.timeLeft <= 0)
        {
            if (transform.position.z < -44.0f)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                anim["Zombie|ZombieWalk"].speed = speedanim;
                anim.Play("Zombie|ZombieWalk");
            }
        }
        
        if(transform.position.z > -44.0f)
        {
        timer.unit-=1;
            Destroy(this.gameObject);
            
        }

    }
}
