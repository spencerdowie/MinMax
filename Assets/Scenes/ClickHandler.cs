using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour, IPointerDownHandler
{
    int index;
    GameManager manager;

    private void Start()
    {
        index = transform.GetSiblingIndex();
        manager = FindObjectOfType<GameManager>();
    }

    public void OnPointerDown(PointerEventData e)
    {
        manager.ClickTile(index);
    }
}
