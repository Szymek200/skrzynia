using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyRing : MonoBehaviour
{
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
        if (x == 1)
        {
            


            if (couter < timeToAct)
            {
                couter += Time.deltaTime;

            }
            else
            {
                SceneManager.LoadScene(1);//przejscie do nastepnej sceny
                x = 0;
                couter = 0;
            }
        }
    }
}
