using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MutationUI : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public GameObject hp;
    public GameObject speed;
    public GameObject multiply;
    public GameObject close;
    public GameObject text;
    public void OnPointerClick(PointerEventData eventData)
    {
        hp.active = true;
        this.gameObject.active = false;
        speed.active = true;
        multiply.active = true;
        close.active = true;
        text.active = false;
    }
}
