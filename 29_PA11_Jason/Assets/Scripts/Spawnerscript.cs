using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    float PositionY;
    public static int asd;
    [SerializeField]
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt.GetComponent<Text>();
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

        txt.text = "Score:" + asd;

    }

    void SpawnObjects()
    {
        //int i = Random.Range(0, SpawnObject.Length);
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        GameObject clone = Instantiate(SpawnObject, transform.position, transform.rotation);
        Destroy(clone, 5);
    }
}
