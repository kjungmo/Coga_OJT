#include "opencv2/opencv.hpp"
#include <iostream>

using namespace cv;
using namespace std;


int main()
{
    cout << "Hello OpenCV " << CV_VERSION << endl;

    Mat img; // empty Mat matrix declared 
    img = imread("a.jpg", IMREAD_GRAYSCALE);

    if (img.empty()) {
        cerr << "Image load failed" << endl;
        return -1;
    }
    Mat imgROI = img(Rect(200, 250, 200, 250));
    imgROI = ~imgROI;

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
    imshow("imageROI", imgROI);

    //namedWindow("practice image");
    imshow("practice image", practice1);


    waitKey();
    return 0;
}