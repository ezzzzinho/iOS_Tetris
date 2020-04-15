using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class RightButtonControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool RpointerDown; // bool czy guzik jest wcisniety (true) badź nie (false);
    void Start()
    {
        InvokeRepeating("reset", 0f, 0.005f); // na starcie powtarzamy aby co klatke wywoływac metodę do zmieniania wartośc bool na false (zapobiegnie to trzymaniu guzika i ciągłemu przesuwaniu bloku, teraz jedno wcisnięcie = przesunięcie o jedną kratkę);
    }


    public UnityEvent onLongClick;

    public void OnPointerDown(PointerEventData evenData) // jesli guzik jest wcisnięty;
    {
        RpointerDown = true;  // to ustawiamy na true;
    }

    public void OnPointerUp(PointerEventData evenData) // jesli jest w górze (czyli nie wcisnięty);
    {
        RpointerDown = false; // to zmieniamy wartośc bool na false;
    }

    public void reset()
    {
        RpointerDown = false;
    }
}
