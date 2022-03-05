using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class OptionScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    // Start is called before the first frame update
    public GameObject texttoactivate;
    public int price;
    public GameObject zombie;
    public GameObject money;
    public GameObject timer;
    public GameObject textprice;
    public void OnPointerExit(PointerEventData eventData)
    {

            texttoactivate.active = false;
     
    }
    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
       
        textprice.GetComponent<TextMeshProUGUI>().text = price.ToString();
        texttoactivate.active = true;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (timer.GetComponent<Timer>().timeLeft > 0 && money.GetComponent<MoneySystem>().Money >= price)
        {
            money.GetComponent<MoneySystem>().Money = money.GetComponent<MoneySystem>().Money - price;
        }
    }
}
