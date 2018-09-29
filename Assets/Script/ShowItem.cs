using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowItem : MonoBehaviour {

    public List<SpriteRenderer> gambar = new List<SpriteRenderer>();
    public Item jumlah;

    void Update () {
        for (int i = 0; i < 4; i++)
        {
            gambar[i].sprite = jumlah.spriter[jumlah.save[i]];
        }
    }
}
