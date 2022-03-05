using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpeedUPG : MonoBehaviour, IPointerClickHandler
{
    public GameObject zombie;
    public GameObject money;
    public GameObject timer;
   
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        if (timer.GetComponent<Timer>().timeLeft > 0 && money.GetComponent<MoneySystem>().Money >= this.GetComponent<OptionScript>().price)
        {
            zombie.GetComponent<ZombieMove>().speed += (float)0.1;
            zombie.GetComponent<ZombieMove>().speedanim += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
