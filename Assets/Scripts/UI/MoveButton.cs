using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    /* fields */
    private LoadPrefab loadPrefab;

    /* Start function */
    void Start()
    {
        this.loadPrefab = new LoadPrefab();
    }

    /* Update function */
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // メインカメラ上のマウス位置からRayをとばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                string name = hit.collider.gameObject.name;
                if(name.Equals("LeftButton"))
                {
                    this.loadPrefab.ChangePrefab(-1);
                } else if(name.Equals("RightButton"))
                {
                    this.loadPrefab.ChangePrefab(1);
                }
            }
        }
    }
}
