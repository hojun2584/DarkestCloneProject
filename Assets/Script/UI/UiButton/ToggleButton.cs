using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : UiButton
{

    TextName viewModel;

    private void Start()
    {

    }


    public void InitModel()
    {

        if (name != null)
            model.Toggle = viewModel;
    }

    public void InventoryButton()
    {
        viewModel = TextName.INVENTORY;
        InitModel();
    }

    public void MapButton()
    {
        viewModel = TextName.MAP;
        InitModel();
    }




}
