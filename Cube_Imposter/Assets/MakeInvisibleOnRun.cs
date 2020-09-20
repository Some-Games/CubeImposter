using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC;
using VRCSDK2;

public class MakeInvisibleOnRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponent<Renderer>())
            gameObject.GetComponent<Renderer>().enabled = false;

        if(gameObject.transform.childCount > 0)
            for(int i = 0; i < gameObject.transform.childCount; ++i)
            {
                GameObject tempChild = gameObject.transform.GetChild(i).gameObject;

                if (tempChild.GetComponent<Renderer>())
                    tempChild.GetComponent<Renderer>().enabled = false;
            }

    }
}
