using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMove : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TextDisappear());
    }

    IEnumerator TextDisappear()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}
