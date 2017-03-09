using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Runtime.InteropServices;

public class final : MonoBehaviour
{

    [DllImport("ConsoleApplication15", EntryPoint = "displaypolygon")]
    public static extern void displaypolygon();

    [DllImport("ConsoleApplication15", EntryPoint = "drawcircle")]
    public static extern void drawcircle();

    [DllImport("ConsoleApplication15", EntryPoint = "markpoint")]
    public static extern void markpoint();


    private int selectedToolbar = 0;
    private string[] toolbarStrings = { "Dislay Polygon", "Display Circle", "Plot Point", "Plot Line" };
    //private string imgpath = "D:/3-2/gsoc'17/CImg-2.0.0_pre030217/lena.jpg";
    //    private string n = "4";
    //    private string arr_s = "150 150 150 200 200 200 200 150";
    private string xc = "400";
    private string yc = "400";
    private string r = "70";
    private string[] arr;
    private int XC;
    private int YC;
    private int R;
    //    private int N;
    //    private int[] ARR = new int[20];
 
    void OnGUI()
    {
        int i;
        GUI.BeginGroup(new Rect(100, 150, 100, 50));
        GUI.Box(new Rect(0, 0, 100, 50), "Choose shapes");
        GUI.Label(new Rect(10, 25, 100, 30), "Among these");
        //imgpath = GUI.TextArea(new Rect(40, 40, 120, 30), imgpath);
        GUI.EndGroup();

        if (GUI.Button(new Rect(300, 145, 100, 50), "Rectangle"))
        {
            Debug.Log("Displaying Rectangle");
            displaypolygon();
        }
        GUI.Label(new Rect(305, 200, 100, 80), "Vertices: (150,150),\n(150,200),\n(200,200),\n(200, 150)\n");
        //n = GUI.TextArea(new Rect(300, 200, 100, 25), n);
        //N = Int32.Parse(n);
        //arr_s = GUI.TextArea(new Rect(300, 220, 100, 150), arr_s);
        //arr = arr_s.Split(' ');
        //for (i = 0; i < 2*N; i++)
        //{
        //    ARR[i] = Int32.Parse(arr[i]);
        //}


        if (GUI.Button(new Rect(450, 145, 100, 50), "Circle"))
        {
            Debug.Log("Displaying Circle");
            drawcircle();/*
            Debug.Log(XC);
            Debug.Log(XC);
            Debug.Log(R); */
        }
        GUI.Label(new Rect(450, 200, 100, 80), "Center: (256,256),\n Radius: 70");
        /*
                xc = GUI.TextArea(new Rect(450, 200, 100, 25), xc);
                XC = Int32.Parse(xc);
                yc = GUI.TextArea(new Rect(450, 220, 100, 25), yc);
                YC = Int32.Parse(yc);
                r = GUI.TextArea(new Rect(450, 240, 100, 25), r);
                R = Int32.Parse(r);
        */
        if (GUI.Button(new Rect(600, 145, 100, 50), "Mark Point"))
        {
            Debug.Log("Plot Point");
            markpoint();
        }
        GUI.Label(new Rect(600, 200, 100, 80), "Point : (256,256)\n");
        /*
                xc = GUI.TextArea(new Rect(600, 200, 100, 25), xc);
                XC = Int32.Parse(xc);
                yc = GUI.TextArea(new Rect(600, 220, 100, 25), yc);
                YC = Int32.Parse(yc);
        */
    }
    void Start()
    {
        OnGUI();
    }
}

