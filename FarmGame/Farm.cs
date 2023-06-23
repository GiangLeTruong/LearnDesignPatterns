using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Farm : MonoBehaviour
{
    [SerializeField] TMP_Dropdown product_Dropdown;

    public struct ProductType
    {
        string name;
        int nums;
        float growing_Time;
        int the_type_of_products;
        float the_number_of_products;
        string unit;
        
            public void set_Type_Start(string product_Name)
        {
                if(product_Name == "Tomato")
                {
                    this.name = product_Name;
                    this.nums = 0;
                    this.growing_Time = 5f;
                    this.the_type_of_products = 0;
                    this.the_number_of_products = 1;
                    this.unit = product_Name;
                }
                else if(product_Name == "Blueberry")
                {
                    this.name = product_Name;
                    this.nums = 0;
                    this.growing_Time = 7f;
                    this.the_type_of_products = 0;
                    this.the_number_of_products = 1;
                    this.unit = product_Name;
                }
                else if (product_Name == "Strawberry")
                {
                    this.name = product_Name;
                    this.nums = 0;
                    this.growing_Time = 10f;
                    this.the_type_of_products = 0;
                    this.the_number_of_products = 1;
                    this.unit = product_Name;
                }
                else if (product_Name == "Cow")
                {
                    this.name = product_Name;
                    this.nums = 0;
                    this.growing_Time = 15.5f;
                    this.the_type_of_products = 0;
                    this.the_number_of_products = 1;
                    this.unit = "gallon";
                }
            }
    }
    private void Update()
    {
        ProductType product=new ProductType();
        product.set_Type_Start(product_Dropdown.options[product_Dropdown.value].text);
    }
    
}
