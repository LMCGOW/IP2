﻿using UnityEngine;
using System.Collections;

public class TileGenerator : MonoBehaviour {

    int[,] tiles = new int[,] { 

        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0}, 
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0},
        {1,2,2,2,2,2,1,1,1,1,1,1,2,2,1,1,0,0,0,0,0,0,0,0},
        {1,2,2,2,2,2,1,1,1,1,1,1,2,2,1,1,0,0,0,0,0,0,0,0},
        {1,2,2,1,2,2,1,1,1,1,1,1,2,2,1,1,0,0,0,0,0,0,0,0},
        {1,2,2,1,2,2,1,1,1,2,2,1,2,2,1,1,0,0,0,0,0,0,0,0},
        {1,2,2,1,2,2,2,2,2,2,2,1,2,2,1,1,0,0,0,0,0,0,0,0},
        {1,2,2,1,2,2,2,2,2,2,2,1,2,2,1,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,2,2,1,1,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,2,2,1,1,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,2,2,1,1,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,1,1,1,1,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,1,1,1,1,2,2,1,1,1,1,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,1,1,1,1,2,2,1,1,1,1,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,1,1,1,1,2,2,1,1,1,1,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,1,1,1,1,2,2,1,1,1,1,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,1,1,1,1,2,2,1,1,1,1,1,0,0,0,0,0,0,0,0},
        {1,2,1,1,1,1,1,1,1,2,2,1,1,1,1,1,0,0,0,0,0,0,0,0},
        {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0},
        {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0},
        {1, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 3, 3, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 3, 3, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 1, 3, 3, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 2, 2, 2, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 2, 2, 2, 2, 2, 1, 1, 2, 2, 1, 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 4, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        {3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {3, 3, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 1 },
        {1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1 },
        {1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1 },
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
  


    };

    public Transform[] tile;

    Rect tilePosition;


	// Use this for initialization
	void Start () {

        for (int y = 0; y < 60; y++)
        {
            for (int x = 0; x < 24; x++)
            {
                if (tiles[y, x] > 0)
                {
                    Instantiate(tile[tiles[y, x]], new Vector3(x * tile[tiles[y, x]].renderer.bounds.size.x, y * tile[tiles[y, x]].renderer.bounds.size.y, 0), new Quaternion(0, 0, 0, 0));
                }

            }
        }

	}
	
	// Update is called once per frame
	void Update () {

  
        

	}

   

 
}
