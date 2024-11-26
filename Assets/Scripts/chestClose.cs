using UnityEngine;
using UnityEngine.InputSystem.Android;


public class chestClose : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject prefabopen;//otwarta skrzynia
    [SerializeField] private GameObject prefabclosed;

    [SerializeField] private GameObject prefabEnemy;

    private float couter = 0;
    private float timeToAct = 1; //jak dlugo mamy czekac
    enum CountingMethod
    {
        Frames,
        Coroutine,
        Invoke
    }

    [SerializeField] private CountingMethod countingMethod;
    private int x = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
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


                if (GetComponent<Collider2D>().OverlapPoint(mousePosition))
                {
                    Destroy(prefabopen);
                    Instantiate(prefabclosed, new Vector2(0, 0), Quaternion.identity);
                   
                }


            }

           

            
        }



        if (x==1)
        {
            /*if(countingMethod == CountingMethod.Frames)
            {
                if(couter < timeToAct)
                {
                    couter += Time.deltaTime;

                }
                else
                {
                    Instantiate(prefabEnemy, new Vector2(0, 0), Quaternion.identity);
                    x = 0;
                    couter = 0;
                }
            }*/
            

             if (couter < timeToAct)
              {
                  couter += Time.deltaTime;

              }
              else
              {
                  Instantiate(prefabEnemy, new Vector2(0, 0), Quaternion.identity);
                  x = 0;
                  couter = 0;
              }
        }
    }

    void showEnemy()
    {
         ;

    }

    /*private void OnMouseDown()
    {
        Instantiate(prefabopen, new Vector2(0, 0), Quaternion.identity);
       // Destroy(prefabclosed);
    }*/
}
