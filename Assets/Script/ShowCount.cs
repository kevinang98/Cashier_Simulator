using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCount : MonoBehaviour {

    public List<Text> jumlah = new List<Text>();
    public Item barang;
	
	void Update () {
		for(int i = 0; i < 4; i++)
        {
            jumlah[i].text = "x" + barang.itemCount[i];
        }
	}
}
