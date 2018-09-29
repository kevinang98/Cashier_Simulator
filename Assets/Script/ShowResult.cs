using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour {

    public Canvas hasil;
    public Text tulis;
    public GameObject barang;

    void Start()
    {
        hasil.gameObject.SetActive(false);
    }
}
