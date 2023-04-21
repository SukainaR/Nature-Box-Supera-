using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    // Create an array with the sequence of reference points, in order
    // create a second array to keep track of the spawned models

    public GameObject[] modelTemplates;
    public Transform[] parentTransforms;
    // Start is called before the first frame update
    private List<GameObject> spawnedObjects = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < modelTemplates.Length; ++i)
        {
            GameObject spawnedObject = Instantiate(modelTemplates[i], parentTransforms[i].position, parentTransforms[i].rotation);

            spawnedObject.transform.parent = parentTransforms[i];

            spawnedObjects.Add(spawnedObject);
        }
    }

    // Create a function to hook into the Canvas Button
    // Its sole responsibility is to receive that request and check if you can spawn a model, if you can spawn her on the next available spot
}
