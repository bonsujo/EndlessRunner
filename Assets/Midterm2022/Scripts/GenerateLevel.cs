using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] Section;
    public int zPos = 20;
    public bool createSection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if (createSection == false)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(Section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);

        zPos += 20;
        yield return new WaitForSeconds(2);
        createSection = false;
    }
}
