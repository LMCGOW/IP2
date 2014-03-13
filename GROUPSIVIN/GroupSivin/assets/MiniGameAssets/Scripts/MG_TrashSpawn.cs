using UnityEngine;
using System.Collections;

public class MG_TrashSpawn : MonoBehaviour {

    public GameObject trash;

    float timer = 0f;

	// Use this for initialization
	void Start () {

        AddTrash();

	}
	
	// Update is called once per frame
	void Update () {

        CheckForNewTrash();

	}

    void CheckForNewTrash()
    {
        timer += Time.deltaTime;

        if (timer >= 3)
        {
            AddTrash();
            timer = 0;
        }
    }

    void AddTrash()
    {
        Instantiate(trash, this.transform.position, new Quaternion(0, 0, 0, 0));
    }
}
