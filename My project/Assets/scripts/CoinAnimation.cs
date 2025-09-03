using UnityEngine;

public class CoinAnimation : MonoBehaviour
{

    const int RotaionSpeed1 = 1;
    const int RotaionSpeed2 = 1;
    const int RotaionSpeed3 = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotaionSpeed1 * Time.deltaTime, RotaionSpeed2 * Time.deltaTime, RotaionSpeed3 * Time.deltaTime, Space.World);
    }
}
