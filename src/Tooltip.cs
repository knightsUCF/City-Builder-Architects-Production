using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;





public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public GameObject panel;
    public Text text;

    
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        panel.SetActive(true);
    }


    
    public void OnPointerExit(PointerEventData eventData)
    {
        panel.SetActive(false);
    }
}
