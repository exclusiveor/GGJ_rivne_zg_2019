//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class InteractiveObj : MonoBehaviour
//{
//    public GameController gameController;

//    public bool isSelected;

//    private void Start()
//    {
//        gameController.interactives.Add(this);
//    }

//    private void OnMouseDown()
//    {
//        if (gameController.selectedObject != gameObject)
//        {
//            gameController.selectedObject = gameObject;
//            isSelected = true;
//        }
//    }

//    private void OnMouseUp()
//    {
//        isSelected = false;
//        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
//    }

//    void OnCollisionEnter(Collision collision)
//    {
//        Debug.Log(gameController.selectedObject);

//        if (gameController.selectedObject != collision.gameObject)
//        {
//            InteractiveObj interactiveObj = collision.gameObject.GetComponent<InteractiveObj>();
//            if (interactiveObj != null)
//            {
//                interactiveObj.isSelected = true;
//                gameController.selectedObject = interactiveObj.gameObject;
//            }
//        }
//    }


//    //private void OnMouseOver()
//    //{
//    //    //Color col = gameObject.GetComponent<Renderer>().material.color;
//    //    //col = new Vector4(col.r, col.g, col.b, 150f);
//    //    //gameObject.GetComponent<Renderer>().material.color = col;
//    //}


//    //private void CheckifSomethingUnder()
//    //{
//    //    RaycastHit hit;
//    //    Ray ray = new Ray(transform.position, Vector3.down);

//    //    if (Physics.Raycast(ray, out hit))
//    //    {
//    //        if (hit.collider != null)
//    //        {
//    //            Debug.Log(hit.collider.gameObject.name);
//    //           InteractiveObj hitObj = hit.collider.gameObject.GetComponent<InteractiveObj>();
//    //            if (hitObj != null)
//    //            {
//    //                hitObj.isSelected = true;
//    //            }
//    //        }
//    //    }
//    //}


//    private void Update()
//    {
//        if (isSelected)
//        {
//            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
//            transform.position = new Vector3(pos.x, 2, pos.z);
//        }
//    }

//}
