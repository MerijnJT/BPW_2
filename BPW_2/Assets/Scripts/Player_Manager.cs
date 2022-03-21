using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    public bool nearTable;
    public LayerMask Table;
    public Camera cam1;
    public Camera cam2;

    public static bool isPause;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        nearTable = Physics.CheckSphere(transform.position, 2f, Table);

        if (nearTable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                cam1.enabled = !cam1.enabled;
                cam2.enabled = !cam2.enabled;
                if (cam2.enabled)
                {
                    Cursor.lockState = CursorLockMode.None;
                    isPause = true;
                }
                else
                {
                    isPause = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }

        }
    }
}
