using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timer_text;
    public Slider s;
    public Image round;
    public bool set;
    public float re;
    public Text timer_text_tr;
    public float sewt_tt;
    public GameObject center;
    public GameObject record_menu;
    public GameObject job_menu;

    public GameObject d_group;
    public GameObject t_group;

    public List<record_content> record;
    
    public GameObject record_view;
    void Update()
    {
        if (set == false)
        {
            round.fillAmount = Mathf.Floor(s.value*60)/60;
            timer_text.text = (Mathf.Floor(s.value * 60f)).ToString() + " 분";
        }
        else
        {
            re -= Time.deltaTime;
            sewt_tt = re / 3600;
            if (re <= 0)
            {
                set = false;
                d_group.SetActive(true);
                t_group.SetActive(false);
            }
            else
            {
                round.fillAmount = sewt_tt;
                float m = Mathf.Floor(re/60f);
                float s = (re%60);
                
                timer_text_tr.text = string.Format("{0:00} : {1:00}", m, s);
            }
            
        }
        
    }

    public void Timer_set()
    {
        re = round.fillAmount * 3600f;
        set = true;
    }

    public void canceal()
    {
        set = false;
        d_group.SetActive(true);
        t_group.SetActive(false);
    }

    public void record_set()
    {
        GameObject record_v = Instantiate(Resources.Load("content") as GameObject);
        record_v.transform.SetParent(record_view.transform);
        record_v.transform.localScale = new Vector3(1, 1, 1);
        record_v.transform.GetChild(0).GetComponent<Text>().text = (Mathf.Floor(s.value * 60f)).ToString() + " 분";
        record_v.GetComponent<record_content>().index = record.Count;
        record_v.GetComponent<record_content>().time = round.fillAmount;
        record_v.GetComponent<record_content>().upper = this;
        record_v.GetComponent<record_content>().center = center;
        record_v.GetComponent<record_content>().record_menu = record_menu;
        record.Add(record_v.GetComponent<record_content>());

    }

}
