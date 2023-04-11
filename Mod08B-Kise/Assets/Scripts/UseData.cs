using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{/**
  * Tutorial link
  * https://github.com/tikonen/blog/tree/master/csvreader
  * */

    List<Dictionary<string, object>> data;
    public GameObject myCube;//prefab
    int rowCount; //variable 
    private float startDelay = 2.0f;
    private float timeInterval = 0.1f;
    public object tempObj;
    public float tempFloat;
    public float temptempFloat;


    void Awake()
    {

        data = CSVReader.Read("CO2DATA");//udata is the name of the csv file 

        for (var i = 0; i < data.Count; i++)
        {
            //name, age, speed, description, is the headers of the database
            print("xco2 " + data[i]["xco2"] + " ");
        }


    }//end Awake()

    // Use this for initialization
    void Start()
    {

        InvokeRepeating("SpawnObject", startDelay, timeInterval);
    }//end Start()

    // Update is called once per frame
    void Update()
    {
        /* for (var i = 0; i < data.Count; i++)
         {
             object xco2 = data[i]["xco2"];//get age data


             gameObject.transform.localScale = new Vector3((float)xco2, (float)xco2, (float)xco2);
             // cubeCount += (int)xco2;//convert age data to int and add to cubeCount
             //Debug.Log("cubeCount " + cubeCount);
         }*/
        //As long as cube count is not zero, instantiate prefab
        /* while (cubeCount > 0)
         {
             Instantiate(myCube);
             cubeCount--;
             Debug.Log("cubeCount" + cubeCount);
         }*/



    }//end Update()
    void SpawnObject()
    {
        tempObj = (data[rowCount]["xco2"]);
        tempFloat = System.Convert.ToSingle(tempObj);
        rowCount++;
        temptempFloat = tempFloat;
      tempFloat = (tempFloat*0.05f);



        Vector3 rot = new Vector3(0 , tempFloat, 0);
            transform.Rotate(rot);

      
       transform.localScale = Vector3.Lerp(transform.localScale,new Vector3(tempFloat, tempFloat, tempFloat), Time.deltaTime*300);
        Debug.Log("The tempFloat is: " + tempFloat);
        Debug.Log("The count is: " + rowCount);


    }

}