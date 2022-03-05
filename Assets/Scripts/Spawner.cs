using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject money;
    public int SpawnCounter = 0;
    public GameObject texttoactivate;
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
        texttoactivate.active = false;
    }
    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        texttoactivate.active = true;
    }
    private void OnMouseExit()
    {
        texttoactivate.active = false;
    }
}
