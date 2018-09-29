using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAI : MonoBehaviour {

    public float speed = 4.5f;
    private Rigidbody2D customer;
    private Vector3 p1 = new Vector3(2f, 2.5f, -1f);
    private Vector3 p2 = new Vector3(0.7f, 2.5f, -1f);
    private Vector3 p3 = new Vector3(-0.6f, 2.5f, -1f);
    private Vector3 pEnd = new Vector3(-3.8f, 2.5f, -1f);
    public int phase;
    public Item benda;
    public SpriteRenderer chara;
    public int cekEks;
    public int sex;

    void Awake () {
        benda = FindObjectOfType<Item>();
        customer = this.GetComponent<Rigidbody2D>();
        chara = this.GetComponent<SpriteRenderer>();
        sex = benda.gender;
        phase = 0;

        if(sex % 2 != 0)
        {
           chara.sprite = benda.emo[0];
        }
        else if(sex % 2 == 0)
        {
            chara.sprite = benda.emo[3];
        }
    }
	

	void Update () {

        if(phase == 1)
        {
            jalan();
            if (gameObject.transform.position == p1)
            {
                stop();
            }
        }else if (phase == 2)
        {
            jalan();
            if (gameObject.transform.position == p2)
            {
                stop();
            }
        }else if (phase == 3)
        {
            jalan();
            if (gameObject.transform.position == p3)
            {
                stop();
                if(benda.turn == 1)
                {
                    benda.bubble.gameObject.SetActive(true);
                    benda.request.gameObject.SetActive(true);
                    benda.barang.gameObject.SetActive(true);
                    benda.pembayaran.gameObject.SetActive(false);
                }
                if (benda.turn == 2)
                {
                    benda.bubble.gameObject.SetActive(true);
                    benda.request.gameObject.SetActive(false);
                    benda.barang.gameObject.SetActive(false);
                    benda.pembayaran.gameObject.SetActive(true);
                }
            }
        }else if (phase == 4)
        {
            jalan();
            if (gameObject.transform.position == pEnd)
            {
                stop();
                Destroy(this.gameObject);
            }
        }

        if (benda.cekJawab == 0 && phase == 3)
        {
            if (sex % 2 != 0)
            {
                chara.sprite = benda.emo[0];
            }
            else if (sex % 2 == 0)
            {
                chara.sprite = benda.emo[3];
            }
        }
        else if (benda.cekJawab == 1 && phase == 3 && benda.stay == false)
        {
            StartCoroutine("Wait2");
        }
        else if (benda.cekJawab == 2 && phase == 3)
        {
            StartCoroutine("Wait3");
        }
        else if (benda.cekJawab == 1 && phase == 4 && benda.stay == true)
        {
            StartCoroutine("Wait2");
        }
    }

    void jalan()
    {
        customer.velocity = transform.TransformDirection(Vector2.left * speed);
    }

    void stop()
    {
        customer.velocity = Vector2.zero;
    }

    IEnumerator Wait2()
    {
        if (sex % 2 != 0)
        {
            chara.sprite = benda.emo[2];
        }
        else if (sex % 2 == 0)
        {
            chara.sprite = benda.emo[5];
        }
        yield return new WaitForSeconds(1);
        benda.cekJawab = 0;
    }

    IEnumerator Wait3()
    {
        if (sex % 2 != 0)
        {
            chara.sprite = benda.emo[1];
        }
        else if (sex % 2 == 0)
        {
            chara.sprite = benda.emo[4];
        }
        yield return new WaitForSeconds(1);
        benda.cekJawab = 0;
    }
}
