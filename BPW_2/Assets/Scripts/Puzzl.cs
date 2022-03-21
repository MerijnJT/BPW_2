using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzl : MonoBehaviour
{
    public GameObject tile;
  
    private Puzzl_Manager puzzleManager;
        
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            puzzleManager.SelectBlock(this, tile);
        }
        Debug.Log(this.name);
    }



    private void Start()
    {
        puzzleManager = GetComponentInParent<Puzzl_Manager>();
    }

}
