using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class screen : MonoBehaviour
{
    // Start is called before the first frame update
    public bool on_menu;
    public GameObject menu;

       
    public void set_size_to(int index)
    {
        switch (index)
        {
            case 0:
                Screen.SetResolution(400, 800, false);
                break;
            case 1:
                Screen.SetResolution(300, 600, false);
                break;
            case 2:
                Screen.SetResolution(350, 700, false);
                break;
            
        }
    }

    public void menu_on_off()
    {
        if (on_menu)
        {
            on_menu = false;
            menu.SetActive(false);
            menu.GetComponent<DOTweenAnimation>().DORestartById("out");
        }
        else
        {
            on_menu = true;
            menu.SetActive(true);
            menu.GetComponent<DOTweenAnimation>().DORestartById("in");
        }
    }
}
