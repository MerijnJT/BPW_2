using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzl_Manager : MonoBehaviour
{


    public Puzzl currentBlock;
    public Puzzl previousBlock;

    public GameObject currentTile;
    public GameObject previousTile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SelectBlock(Puzzl puzzl,GameObject whatTile)
    {
        if (currentBlock)
        {
            if(puzzl == currentBlock)
            {
                currentBlock = null;
                currentTile = null;
                //also undo visuals
                return;
            }
            previousBlock = currentBlock;
            previousTile = currentTile;
        }
        currentBlock = puzzl;
        currentTile = whatTile;
        

        if (currentBlock && previousBlock)
        {
            //swapping functionality
            Vector3 currentLocation = currentBlock.transform.localPosition;
            Vector3 previousLocation = previousBlock.transform.localPosition;

            Vector3 currentTileLocation = currentTile.transform.position;
            Vector3 previousTileLocation = previousTile.transform.position;

            currentBlock.transform.localPosition = previousLocation;
            previousBlock.transform.localPosition = currentLocation;

            currentTile.transform.localPosition = previousTileLocation;
            previousTile.transform.localPosition = currentTileLocation;

            currentBlock = null;
            previousBlock = null;
        }
    }
}
