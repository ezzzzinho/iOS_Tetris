using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TurnButtonControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool TpointerDown;
    void Start()
    {
        InvokeRepeating("reset", 0f, 0.005f); // na starcie powtarzamy aby co klatke wywoływac metodę do zmieniania wartośc bool na false (zapobiegnie to trzymaniu guzika i ciągłemu obracaniu bloku, teraz jedno wcisnięcie =  obrót o 90);
    }


    public UnityEvent onLongClick;

    public void OnPointerDown(PointerEventData evenData) // jesli guzik jest wcisnięty;
    {
        TpointerDown = true;  // to ustawiamy na true;
    }

    public void OnPointerUp(PointerEventData evenData) // jesli jest w górze (czyli nie wcisnięty);
    {
        TpointerDown = false; // to zmieniamy wartośc bool na false;
    }

    public void reset()
    {
        TpointerDown = false;
    }
}

