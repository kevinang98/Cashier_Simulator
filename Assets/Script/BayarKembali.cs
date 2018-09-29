using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BayarKembali : MonoBehaviour {

    public Text bayar;
    public Text total;
    public Item barang;

	void Update () {
        total.text = "Total : " + barang.total;
        bayar.text = "Bayar : " + barang.bayar;
	}
}
