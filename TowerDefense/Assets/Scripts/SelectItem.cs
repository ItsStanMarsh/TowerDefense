using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : InputManager
{
    public GameObject SelectedItem;

    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        if (keys[0] == "Item1")
        {
            SetItem(Resources.Load("Prefabs/Item1") as GameObject);
            ShowSelectedItem();
            keys[0] = "";
        }
        if (keys[0] == "Item2")
        {
            SetItem(Resources.Load("Prefabs/Item2") as GameObject);
            ShowSelectedItem();
            keys[0] = "";
        }
    }

    public void ShowSelectedItem()
    {
        Destroy(GameObject.Find("ItemOnMouse"));
        var InstItem = Instantiate(GetItem(), new Vector3(0, 10, 0), Quaternion.identity);
        InstItem.name = "ItemOnMouse";

    }

    public void SetItem(GameObject item)
    {
        SelectedItem = item;
    }

    public GameObject GetItem()
    {
        return SelectedItem;
    }

}