using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class OptionScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler//, IPointerClickHandler
{
    // Start is called before the first frame update
    public GameObject texttoactivate;
    public void OnPointerExit(PointerEventData eventData)
    {
        texttoactivate.active = false;
    }
    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        texttoactivate.active = true;
    }

}
