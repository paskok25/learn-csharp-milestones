using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int i = 5;
    public int i1 = 10;
    public float f = 5;
    public string s = "hello";
    public string s1 = "bye";
    public bool b = true;
    private int[] myArray = {1,2,3};
    private List<string> myList = new List<string>() {"A", "B", "C", "D"};
    private Dictionary<string, int> myDictionary = new Dictionary<string, int>(){
        {"Jack", 1},
        {"John", 2},
        {"Joseph", 3}
        
    };  

    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform; 

    // single line comment
    /* multi line
    comment*/
    // Start is called before the first frame update
    /// <summary>
    /// stuff
    /// more stuff
    ///</summary>


    void Start()
    {
        /*Debug.Log(i);
        Debug.Log(f);
        Debug.Log(s + s1);
        Debug.Log($"When I leave I say {s1}");
        Debug.Log(Add(i, i1));
        */

        /*if(b == true){
            Debug.Log("yes yes yes");
        }
        else if (b == !true){
            Debug.Log("no no no");
        }

        if(1 == 1){
            if(2 == 2){
                Debug.Log("My name is Paul");
            }
        }

        switch(i){
            case 0:
                Debug.Log("i = 0");
                break;
            case 1:
                Debug.Log("i = 1");
                break;
            case 2:
                Debug.Log("i = 2");
                break;
            case 3:
                Debug.Log("i = 3");
                break;
            default:
                Debug.Log("i > 3");
                break;
        }
        */

        /*for(int i = 0; i < myList.Count; i++){
            if(myList[i] == "C"){
                Debug.Log("The element is at index " + i);
            }
        }

        foreach(string letter in myList){
            Debug.Log("I am the letter " + letter);
        }

        foreach(KeyValuePair<string, int> studentList in myDictionary){
            Debug.LogFormat("Student name: {0} and number: {1}", studentList.Key, studentList.Value);
        } */

        /*Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);

        Character heroine = new Character("Agatha");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = new Weapon("War Bow", 135);
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();*/

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition); 

        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        /*  Chapter 4
        if(i == 20){
             Debug.Log("i is equal to 20");
        }
        else if(i == 3) {
             Debug.Log("i is equal to 3");
        }
        else{
             Debug.Log("i is not 20");
        }*/
    }
    /*  Chapter 3
    public int Add(int x, int y){
        return (x + y);
    }*/
}
