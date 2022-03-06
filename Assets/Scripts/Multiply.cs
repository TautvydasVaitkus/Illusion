using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Multiply : MonoBehaviour, IPointerClickHandler
{
    public GameObject timer;
    public GameObject money;
    public GameObject spawn;
    public int price;
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        price = this.GetComponent<OptionScript>().price;
        if (timer.GetComponent<Timer>().timeLeft > 0 && money.GetComponent<MoneySystem>().Money >= price)
        {
            spawn.GetComponent<Spawner>().multiplier *= 2;
        }
    }
}
