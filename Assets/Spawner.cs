using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour, IPointerClickHandler
{
    public GameObject money;
    public int SpawnCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        money.GetComponent<MoneySystem>().Money = money.GetComponent<MoneySystem>().Money - 5;
        SpawnCounter++;
    }
        public void OnPointerExit(PointerEventData eventData)
    {

    }
    // Update is called once per frame

}
