using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashierMachine : MonoBehaviour {

    public string result = "";
    public float hasil = 0;
    private float temp;
    private Text digit;
    private string Operator;
    public bool cek = false;
    public AudioSource sfx;

    void Start()
    {
        digit = GameObject.FindGameObjectWithTag("Result").GetComponent<Text>();
    }

    private void Update()
    {
        if (result.Length > 8)
        {
            result = result.Substring(0, result.Length - 1);
            displayed();
        }
    }

    public void displayed()
    {
        digit.text = result;
    }

    public void clear()
    {
        result = "0";
        displayed();
    }

    public void type(string x)
    {
        sfx.Play();
        if (result == "0")
        {
            result = x;
        }
        else
        {
            result = result + x;
        }
        displayed();
    }

    public void delete()
    {
        sfx.Play();
        result = result.Substring(0, result.Length - 1);
        if (result.Length == 0)
        {
            result = "0";
        }
        displayed();
    }

    public void equal()
    {
        sfx.Play();
        hasil = float.Parse(result);
        cek = true;
        clear();
    }
}
