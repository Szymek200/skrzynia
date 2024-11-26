using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ChestAction : MonoBehaviour
{
    [SerializeField] private GameObject prefabopen;//otwarta skrzynia
    [SerializeField] private GameObject prefabclosed;


   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /* void Start()
     {
        // Instantiate(prefabclosed, new Vector2(0, 0), Quaternion.identity);
     }



     private void Awake()
     {
         Instantiate(prefabclosed, new Vector2(0, 0), Quaternion.identity);
     }*/

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Instantiate(prefabopen, new Vector2(0, 0), Quaternion.identity);
           // Destroy(prefabopen);

            if (Input.GetMouseButtonDown(0))
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                /*if (GetComponent<Collider2D>().OverLapPoint(mousePosition))
                {
                    //do great stuff
                }*/
                

                if(GetComponent<Collider2D>().OverlapPoint(mousePosition))
                {
                    
                    Instantiate(prefabopen, new Vector2(0, 0), Quaternion.identity);
                    
                    Destroy(prefabclosed);
                }


            }

            


          
        }
    }

  

            
        
    
}
