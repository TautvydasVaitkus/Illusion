using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Spawner : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject money;
    public int SpawnCounter = 0;
    public GameObject texttoactivate;
    public GameObject timer;
    public int price;
    public GameObject textprice;
    public int multiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (timer.GetComponent<Timer>().timeLeft > 0 && money.GetComponent<MoneySystem>().Money >= price)
        {
            money.GetComponent<MoneySystem>().Money = money.GetComponent<MoneySystem>().Money - price;
            SpawnCounter = SpawnCounter + 1 * multiplier;
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        texttoactivate.active = false;
    }
    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        texttoactivate.active = true;
        textprice.GetComponent<TextMeshProUGUI>().text = price.ToString();
    }
    private void OnMouseExit()
    {
        texttoactivate.active = false;
    }
}
