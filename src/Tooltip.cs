using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;




// mouse over does not work with GUI elements

/*

Use

- place Tooltip code on the Button element
- under the button create a game object "Tooltip panel"
- under the game object create a panel, and text
- center the rect transform, don't have to do anything else
- drag to where needed

*/




public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public GameObject panel;
    // public Text text;

    

    public void OnPointerEnter(PointerEventData eventData)
    {
        panel.SetActive(true);
    }


    
    public void OnPointerExit(PointerEventData eventData)
    {
        panel.SetActive(false);
    }
}
