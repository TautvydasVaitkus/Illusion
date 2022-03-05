using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed = 3.0f;
    public Animation anim;
    Rigidbody m_Rigidbody;
    private Timer timer;
    public int UnitsToWin = 5;
    public int speedanim = 1;
    Collider m_ZombieCollider;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        m_Rigidbody = GetComponent<Rigidbody>();
        timer = FindObjectOfType<Timer>();
        m_ZombieCollider = GetComponent<Collider>();

        m_ZombieCollider.isTrigger = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (timer.timeLeft >= 0)
        {
            anim.Play("Zombie|ZombieIdle");
        }  
        
        if (timer.timeLeft <= 0)
        {
            if (transform.position.z > -44.0f)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                anim["Zombie|ZombieWalk"].speed = speedanim;
                anim.Play("Zombie|ZombieWalk");
            }
        }
        
        if(m_ZombieCollider.isTrigger == true)
        {
            UnitsToWin -= 1;
            Destroy(this.gameObject);
        }

    }
}
