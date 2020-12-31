#include "opencv2/opencv.hpp"
#include <iostream>
#include <stdio.h>

using namespace cv;
using namespace std;


int maiwn()
{
    cout << "Hello OpenCV " << CV_VERSION << endl;

    Mat img; // empty Mat matrix declared 
    img = imread("a.jpg", IMREAD_GRAYSCALE);

    if (img.empty()) {
        cerr << "Image load failed" << endl;
        return -1;
    }


    Mat imgROI1 = img(Rect(200, 250, 200, 250));
    imgROI1 = ~imgROI1;
    Mat imgROI2 = img(Rect(200, 250, 200, 250)).clone();
    //Error
    //Mat imgROI2 = img(Rect(200, 320, 200, 320)).clone(); 
    imgROI2 = imgROI2;

    Mat rotated90(Size(512, 512), CV_8UC1);

    for (int j = 0; j < img.rows; j++)
    {
        for (int i = 0; i < img.cols; i++)
        {
            rotated90.at<uchar>(i, img.rows - 1 - j) = img.at<uchar>(j, i);
            int val = img.at<uchar>(j, i);  
            //printf("%d ", val);
        }
    }

    // diffenence between just 0 and Scalar(0)?
    //Mat practice1(300, 300, CV_8UC1, 0);
     Mat practice1(300, 300, CV_8UC1, Scalar(0));

    Mat practice2 = practice1.clone();
    //cout << img.row << endl;

    img = ~img;
    //namedWindow("image");
    imshow("image", img);
     
    // without using namedWindow, still works fine
    //namedWindow("imageROI");
    imshow("imageROI2", imgROI1);
    imshow("imageROI1", imgROI2);
    
    imshow("90RO", rotated90);

    //namedWindow("practice image");
    imshow("practice image", practice1);


    waitKey();
    return 0;
}