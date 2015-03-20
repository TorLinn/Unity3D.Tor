using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public Transform objS;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt (objS); // Поточний об'єкт дивіться на obj
		transform.position = Vector3.MoveTowards (transform.position, objS.transform.position, 0.05f); 
		//transform.localPosition -= new Vector3 (0f, 0f, 0.1f);
	}
}

/*
using UnityEngine;
using System.Collections;

public class transcls : MonoBehaviour
{
    public Transform obj;
    //public int test;
    Vector3 v3a = new Vector3 (-26f, 1f, 35f);
    Vector3 v3b = new Vector3 (0, 0, 0);
    int i = 1;
  
    void Start ()
    {
        /*print (transform.position.ToString ());
        print (obj.position.ToString ());
        print (obj.localPosition.ToString ());
        transform.eulerAngles = new Vector3 (0f, 0f, 45f);
        transform.eulerAngles = new Vector3 (0f, 0f, 45f);
        //transform.Find ("New Sprite 3").transform.Rotate (0, 0, 90f);
        transform.localRotation = new Quaternion (0, 0, 90f, 0);
        print (transform.childCount); // Кількість дочірніх обєктів  

        test = 1;
        for (int i=1; i<5; i++) {
            Transform tr = (Transform)Instantiate (obj, new Vector3 (i * 5f, i * 5f, i * 5f), new Quaternion (0, 0, 0, 0)); // Створення нового об'єкта
            tr.parent = transform; // Створений об'єкт tp робимо дочірнім відносно поточного 
        }
Vector2 v2 = new Vector2 (1f, 2f);
}    

void Update ()
{    
	transform.Rotate (0, 0, -1f); // Поворот на 1 градус
	transform.LookAt (obj); // Поточний об'єкт дивіться на obj
	
	// Інтерполяція 
	transform.position = Vector3.MoveTowards (transform.position, v3b, 0.3f); 
	
	transform.position = Vector3.Lerp(v3a, v3b, i / 300f);
	i++;
}
}



using UnityEngine;
using System.Collections;

public class HelloUnity : MonoBehaviour
{
	transcls cls;
	
	void Start ()
	{
		cls = transform.root.GetComponent<transcls> ();
	}
	
	void OnMouseDown ()
	{
		cls.test++;
	}
	
}


 */
