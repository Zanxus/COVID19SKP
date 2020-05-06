﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private Grid<bool> grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid<bool>(10, 10, 10f, new Vector3(0,0), () => new bool());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(),true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
        //Debug.Log(UtilsClass.GetMouseWorldPosition());
    }
}
