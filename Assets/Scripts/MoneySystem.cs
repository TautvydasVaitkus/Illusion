using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoneySystem : MonoBehaviour
{
    public int Money;
    // Start is called before the first frame update
    public GameObject text;
    public void Update()
    {
        text.GetComponent<TextMeshProUGUI>().text = Money.ToString();
    }

}
