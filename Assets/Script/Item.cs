using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    public List<int> save = new List<int>();
    public List<int> itemCount = new List<int>();
    public List<float> value = new List<float>();
    public List<Sprite> spriter = new List<Sprite>();
    public List<Sprite> emo = new List<Sprite>();
    public Canvas request;
    public Canvas pembayaran;
    public GameObject barang;
    ItemList list;
    public int itemRandomize = 4;
    private int randomize;
    private int itemCountRandom;
    public int turn = 0;
    public float total;
    public float bayar;
    public float harga = 0;
    public CashierMachine kasir;
    public Score skor;
    public Timer waktu;
    public CharacterAI karakter;
    public Image bubble;
    public Transform customerM;
    public Transform customerF;
    public int gender = 0;
    public int cekJawab = 0;
    public bool stay = true;
    CharEmo karakterEmo;

    void Awake()
    {
        new ItemList();
       
        for(int i = 0; i < new ItemList().sprite.Count; i++)
        {
            spriter[i] = new ItemList().sprite[i];
        }

        new CharEmo();

        for (int i = 0; i < new CharEmo().ekspresi.Count; i++)
        {
            emo[i] = new CharEmo().ekspresi[i];
        }

        request.gameObject.SetActive(false);
        pembayaran.gameObject.SetActive(false);
        bubble.gameObject.SetActive(false);
        spawn();
        spawn();
        spawn();
        turn = 1;
        AddBarang();
        for (int i = 0; i < itemRandomize; i++)
        {
            Debug.Log("Item " + save[i] + " count " + itemCount[i] + " harga " + value[i]);
        }
    }

    void Update()
    {

        if (turn == 1)
        {
            harga = kasir.hasil;
            if (kasir.cek == true)
            {
                if (harga == total)
                {
                    Debug.Log("benar");
                    cekJawab = 1;
                    stay = false;
                    kasir.cek = false;
                    skor.score += 100;
                    waktu.time += 10;
                    turn = 2;                   
                    Debug.Log("Total = " + total);
                    Debug.Log("Bayar = " + bayar);
                }
                else
                {
                    waktu.time -= 2;
                    Debug.Log("salah");
                    cekJawab = 2;
                    kasir.cek = false;
                }
            }
        }

        if (turn == 2)
        {
            harga = kasir.hasil;
            if (kasir.cek == true)
            {
                if (harga == bayar - total)
                {
                    Debug.Log("benar");
                    cekJawab = 1;
                    stay = true;
                    kasir.cek = false;
                    skor.score += 50;
                    waktu.time += 5;
                    bubble.gameObject.SetActive(false);
                    request.gameObject.SetActive(false);
                    barang.gameObject.SetActive(false);
                    pembayaran.gameObject.SetActive(false);
                    spawn();
                    turn = 1;
                    total = 0;
                    AddBarang();
                    for (int i = 0; i < itemRandomize; i++)
                    {
                        Debug.Log("Item " + save[i] + " count " + itemCount[i] + " harga " + value[i]);
                    }
                }
                else
                {
                    waktu.time -= 1;
                    Debug.Log("salah");
                    cekJawab = 2;
                    kasir.cek = false;
                }
            }
        }
    }

    public void AddBarang()
    {
        save.Clear();
        itemCount.Clear();
        value.Clear();
        for (int i = 0; i < itemRandomize; i++)
        {
            do
            {
                randomize = Random.Range(0, new ItemList().sprite.Count);
            } while (save.IndexOf(randomize) != -1);
            save.Add(randomize);
            itemCountRandom = Random.Range(1, 9);
            itemCount.Add(itemCountRandom);
            value.Add(new ItemList().value[randomize]);
        }

        for (int i = 0; i < itemRandomize; i++)
        {
            total = total + (itemCount[i] * value[i]);
        }

        do
        {
            bayar = Random.Range(total, total + Random.Range(1, 100));
        } while ((bayar % 1) != 0);
    }


    void spawn()
    {
        Debug.Log(gender);
        gender = Random.Range(0, 100);

        if (gender % 2 != 0)
        {
            Instantiate(customerM);
        }
        else if (gender % 2 == 0)
        {
            Instantiate(customerF);
        }
        GameObject[] c = GameObject.FindGameObjectsWithTag("Customer");
        foreach(GameObject o in c)
        {           
            o.GetComponent<CharacterAI>().phase++;
        }
    }
}
