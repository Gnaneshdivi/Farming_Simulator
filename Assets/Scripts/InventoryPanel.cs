using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : MonoBehaviour
{
    [SerializeField] ItemContainer inventory;
    [SerializeField] List<InventoryButton> buttons;

    // Start is called before the first frame update
    private void Start()
    {
        SetIndex();
        Show();
    }

    private void SetIndex()
    {
        for (int i=0; i<inventory.itemSlots.Count; i++)
        {
            buttons[i].SetIndex(i);
        }
    }

    // Update is called once per frame
    private void Show()
    {
        for (int i = 0; i < inventory.itemSlots.Count; i++)
        {
            if (inventory.itemSlots[i].item == null)
            {
                buttons[i].Clean();
            }

            else
            {
                buttons[i].Set(inventory.itemSlots[i]);
            }
        }
    }
}
