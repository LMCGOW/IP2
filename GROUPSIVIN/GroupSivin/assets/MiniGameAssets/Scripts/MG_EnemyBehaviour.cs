using UnityEngine;
using System.Collections;

public class MG_EnemyBehaviour : MonoBehaviour {

    public GameObject background;

    public float speed = 0.02f;

	// Use this for initialization
	void Start () {
	
        

	}
	
	// Update is called once per frame
	void Update () {

        MoveEnemy();
        DestroyEnemy();

	}

    void MoveEnemy()
    {

        this.transform.position -= new Vector3(0, speed, 0);

    }

    void DestroyEnemy()
    {

        Vector2 mouseLocation = Input.mousePosition;

    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
