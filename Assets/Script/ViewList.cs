using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewList : MonoBehaviour {

    public Canvas kalku;
    public Canvas list;
    public bool cek = false;

    public void liat()
    {
        if(cek == false)
        {
            cek = true;
            kalku.gameObject.SetActive(false);
            list.gameObject.SetActive(true);
        }
        else if(cek == true)
        {
            cek = false;
            kalku.gameObject.SetActive(true);
            list.gameObject.SetActive(false);
        }
    }
}
