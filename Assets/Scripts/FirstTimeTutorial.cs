using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTimeTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject objectRunFirstTime;

    void Start()
    {
        if (PlayerPrefs.GetInt("IsFirst") == 0)
        {
           objectRunFirstTime.SetActive(true); 
            PlayerPrefs.SetInt("IsFirst", 1);
            PlayerPrefs.Save();         
        }
        else
        {
            objectRunFirstTime.SetActive(false);
        }
    }
}
