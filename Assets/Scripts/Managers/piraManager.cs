using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piraManager : MonoBehaviour
{

    public GameObject tetrahedron; // prefab da camrera
    public GameObject[] vetGameObj = new GameObject[24];
    GameObject pai;
    Vector3 m_Center;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            if (i == 0)
            {
                vetGameObj[i] = Instantiate(tetrahedron, new Vector3(0, 0, 0), Quaternion.identity); // tetraedro base
            }
            else
                vetGameObj[i] = Instantiate(tetrahedron, new Vector3(vetGameObj[i - 1].transform.position.x + 1, 0, 0), vetGameObj[i - 1].transform.rotation);
            //i-1 posicao anterior
        }

        //pegar tetra da posicao 3 e transladar
        //1 face
        vetGameObj[3].transform.position = new Vector3(0.5f, 0.86603f, 0.28868f);
        vetGameObj[3].transform.Rotate(110f, 0f, 0); // 90f
        vetGameObj[4].transform.position = new Vector3(1.5f, 0.86603f, 0.28868f);
        vetGameObj[4].transform.Rotate(110f, 0f, 0);
        vetGameObj[5].transform.position = vetGameObj[3].transform.position;
        vetGameObj[6].transform.position = new Vector3(vetGameObj[1].transform.position.x, vetGameObj[1].transform.position.y + 1.70603f, vetGameObj[1].transform.position.z + 0.58858f);
        vetGameObj[6].transform.Rotate(110f, 0f, 0);
        vetGameObj[7].transform.position = vetGameObj[4].transform.position;
        vetGameObj[8].transform.position = vetGameObj[6].transform.position;
        Debug.Log(vetGameObj[2].transform.position.x);

        //2 face
        vetGameObj[9].transform.position = new Vector3(vetGameObj[0].transform.position.x, vetGameObj[0].transform.position.y, vetGameObj[0].transform.position.z+2);
        vetGameObj[9].transform.Rotate(110f, 0f, 0f); // 90f
/*        vetGameObj[10].transform.position = new Vector3(vetGameObj[9].transform.position.x+1, vetGameObj[9].transform.position.y, vetGameObj[9].transform.position.z);
        vetGameObj[11].transform.position = new Vector3(vetGameObj[9].transform.position.x + 2, vetGameObj[9].transform.position.y, vetGameObj[9].transform.position.z);
        vetGameObj[12].transform.position = new Vector3(vetGameObj[9].transform.position.x+0.5f, vetGameObj[9].transform.position.y+ 0.86603f, vetGameObj[9].transform.position.z+ 0.28868f);
        vetGameObj[12].transform.Rotate(110f, 0f, 0); // 90f
        vetGameObj[13].transform.position = new Vector3(vetGameObj[10].transform.position.x + 0.5f, vetGameObj[10].transform.position.y + 0.86603f, vetGameObj[10].transform.position.z + 0.28868f);
        vetGameObj[13].transform.Rotate(110f, 0f, 0);
        vetGameObj[14].transform.position = vetGameObj[12].transform.position;
        vetGameObj[15].transform.position = new Vector3(vetGameObj[10].transform.position.x, vetGameObj[10].transform.position.y + 1.70603f, vetGameObj[10].transform.position.z + 0.58858f);
        vetGameObj[15].transform.Rotate(110f, 0f, 0);
        vetGameObj[16].transform.position = vetGameObj[13].transform.position;
        vetGameObj[17].transform.position = vetGameObj[15].transform.position;

        //3 face
        vetGameObj[18].transform.position = new Vector3(vetGameObj[9].transform.position.x + 4, vetGameObj[9].transform.position.y, vetGameObj[9].transform.position.z);
        vetGameObj[19].transform.position = new Vector3(vetGameObj[18].transform.position.x + 1, vetGameObj[18].transform.position.y, vetGameObj[18].transform.position.z);
        vetGameObj[20].transform.position = new Vector3(vetGameObj[18].transform.position.x + 2, vetGameObj[18].transform.position.y, vetGameObj[18].transform.position.z);
        vetGameObj[21].transform.position = new Vector3(vetGameObj[18].transform.position.x + 0.5f, vetGameObj[18].transform.position.y + 0.86603f, vetGameObj[18].transform.position.z + 0.28868f);
        vetGameObj[21].transform.Rotate(110f, 0f, 0); // 90f
        vetGameObj[22].transform.position = new Vector3(vetGameObj[19].transform.position.x + 0.5f, vetGameObj[19].transform.position.y + 0.86603f, vetGameObj[19].transform.position.z + 0.28868f);
        vetGameObj[22].transform.Rotate(110f, 0f, 0);
        vetGameObj[23].transform.position = vetGameObj[21].transform.position;*/

        //  vetGameObj[11].transform.position = new Vector3(vetGameObj[2].transform.position.x + 3, vetGameObj[2].transform.position.y, vetGameObj[2].transform.position.z);
        //vetGameObj[11].transform.Rotate(0f, -110f, 0f);

        //vetGameObj[5].transform.Rotate(110f,0f,0); 
        // vetGameObj[3].transform.RotateAround(transform.position, Vector3.forward, 5f);

        pai = new GameObject();
        //pai.transform.position = new Vector3(0,1,0); //pivo
        pai.transform.position = new Vector3(0, 1, 0); //pivo
        vetGameObj[3].transform.parent = pai.transform;
        //vetGameObj[3].transform.bounds
    }


    // Update is called once per frame
    void Update()
    {
        //vetGameObj[3].transform.RotateAround(transform.position, Vector3.forward, 5f);
        //cria um gameobject: Pai. Tem eixo de rotacao
        //por o objeto como filho deste gameobject
        //rotaciona o gameObjet(pai): consequencia o filho rotaciona
        //Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);
        //pai.transform.Rotate(Vector3.right * 5);
        //vetGameObj[4].transform.Rotate((Vector3.right + Vector3.up) * 5);
    }
}