using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void OnGUI()
    {
        Debug.Log("OnGUI");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        // InvokeRepeating("myFunction", 1, 1);
        StartCoroutine(TestRoutine());
    }

    IEnumerator TestRoutine()
    {
        yield return new WaitForEndOfFrame();

        Debug.Log("TestRoutine");
    }
    /*
    void myFunction()
    {
        Debug.Log("myFunction");
    }
    */

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
