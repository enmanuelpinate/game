using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Player;
    public GameObject platformPrefab;
    private GameObject myPlat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlat = (GameObject)Instantiate(platformPrefab, new Vector3(Random.Range(-3f, 3f), Player.transform.position.y + (2 + Random.Range(0.5f, 1f))), Quaternion.identity);
        Destroy(collision.gameObject);
    }

}
