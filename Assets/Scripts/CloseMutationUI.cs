using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CloseMutationUI : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public GameObject hp;
    public GameObject speed;
    public GameObject multiply;
    public GameObject mutate;
    public GameObject text;
    public void OnPointerClick(PointerEventData eventData)
    {
        hp.active = false;
        this.gameObject.active = false;
        speed.active = false;
        multiply.active = false;
        mutate.active = true;
        text.active = false;
    }
}
