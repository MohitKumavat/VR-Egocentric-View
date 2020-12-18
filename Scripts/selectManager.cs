using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Zenga";
    [SerializeField] private Material highlightMaterial;
    //[SerializeField] 
    private Material defaultMaterial;
    private Transform _selection;
    private Transform _sel;
    private void OnCollisionEnter(Collision collision)
    {
        if(_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        if (collision.gameObject.tag == "Zenga")
        {
            var selection = collision.gameObject.transform;
            
            if (selection.CompareTag(selectableTag))
            {
                defaultMaterial = collision.gameObject.GetComponent<Renderer>().material;
                var selectionRenderer = selection.GetComponent<Renderer>();
                if(selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }

                _selection = selection;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_sel != null)
        {
            var selRenderer = _sel.GetComponent<Renderer>();
            selRenderer.material = defaultMaterial;
            _sel = null;
        }

        if (other.gameObject.tag == "Zenga")
        {
            var sel = other.gameObject.transform;
            defaultMaterial = other.gameObject.GetComponent<Renderer>().material;
            var selRenderer = sel.GetComponent<Renderer>();
            if(selRenderer != null)
            {
                selRenderer.material = highlightMaterial;
            }
            _sel = sel;
        }
    } 
}
