using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTimeTutorial : MonoBehaviour
{
    // Start is called before the first frame update
        public int IsFirst;
    [SerializeField] private GameObject objectRunFirstTime;

    void Start()
    {
        IsFirst = PlayerPrefs.GetInt("IsFirst");
        if (IsFirst == 0)
        {
           objectRunFirstTime.SetActive(true); 
            PlayerPrefs.SetInt("IsFirst", 1);
          
        }
        else
        {
            objectRunFirstTime.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
