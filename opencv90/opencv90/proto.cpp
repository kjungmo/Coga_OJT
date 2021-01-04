//#include "opencv2/opencv.hpp"
//#include <iostream>
//#include <math.h>
//
//#define PI 3.1415926535897
//
//using namespace cv;
//using namespace std;
//
//class RotationMatrix
//{
//private:
//
//public:
//
//
//};
//
//double getRadian(int _num)
//{
//    return _num * (PI / 180);
//}
//
//double getRotatedMatrix(char *image, int degrees)
//{
//    //int x, y;
//    //double newX, newY, sinSeta, cosSeta;
//
//    Mat sourceImage = imread(image, IMREAD_GRAYSCALE);
//    Mat targetImage(Size(sourceImage.rows, sourceImage.cols), CV_8UC1);
//
//    //sinSeta = sin(getRadian(degrees));
//    //cosSeta = cos(getRadian(degrees));
//    //// rotation of coordinates
//    //newX = (cosSeta * x) - (sinSeta * y); // + centerX
//    //newY = (sinSeta * x) + (cosSeta * y); // + centerY
//    for (int i = 0; i < targetImage.rows; i++)
//    {
//        for (int j = 0; j < targetImage.cols; j++)
//        {
//            targetImage.at<uchar>(i, j) = sourceImage.at<uchar>(getNewX(i, j, degrees), getNewY(i, j, degrees));
//        }
//    }
//    // rotation od axes
//    //newX = (cosSeta * x) + (sinSeta * y) // + centerX
//    //newY = -(sinSeta * x) + (cosSeta * y) // + centerY
//    return 0;
//}
//
//int getNewX(int x, int y, int degrees)
//{
//    int newX = (cos(getRadian(degrees)) * x) - (sin(getRadian(degrees)) * y);
//    return newX;
//}
//
//int getNewY(int x, int y, int degrees)
//{
//    int newY = (sin(getRadian(degrees)) * x) + (cos(getRadian(degrees)) * y);
//    return newY;
//}
//
//void mapForward()
//{
//    
//}
//
//void mapBackward()
//{
//
//}
//
//int mains()
//{
//    cout << "Hello OpenCV " << CV_VERSION << endl;
//
//    Mat sourceImage; // empty Mat matrix declared 
//    sourceImage = imread("a.jpg", IMREAD_GRAYSCALE);
//    cout << "rows : " << sourceImage.rows << endl;
//    if (sourceImage.empty()) {
//        cerr << "Image load failed" << endl;
//        return -1;
//    }
//
//
//    Mat imgROI1 = sourceImage(Rect(200, 250, 200, 250));
//    imgROI1 = ~imgROI1;
//    Mat imgROI2 = sourceImage(Rect(200, 250, 200, 250)).clone();
//    //Error ( because Rect( int _x, int _y, int _width, int _height) not Rect(int _rowrange1, int _rowrange2, int _colrange1, int _colrange2)) 
//    //Mat imgROI2 = img(Rect(200, 320, 200, 320)).clone(); 
//    imgROI2 = imgROI2;
//
//    Mat rotated90(Size(512, 512), CV_8UC1);
//
//    for (int j = 0; j < sourceImage.rows; j++)
//    {
//        for (int i = 0; i < sourceImage.cols; i++)
//        {
//            rotated90.at<uchar>(i, sourceImage.rows - 1 - j) = sourceImage.at<uchar>(j, i);
//            int val = sourceImage.at<uchar>(j, i);
//            //cout << val << endl;//printf("%d ", val);
//        }
//    }
//
//    // diffenence between just 0 and Scalar(0)?
//    // MUST use Scalar() / not int ( see document [ void* ])
//    Mat practice1(300, 300, CV_8UC1, 1);
//     //Mat practice1(300, 300, CV_8UC1, Scalar(0));
//
//    Mat practice2 = practice1.clone();
//    //cout << img.row << endl;
//
//    sourceImage = ~sourceImage;
//    //namedWindow("image");
//    imshow("image", sourceImage);
//     
//    // without using namedWindow, still works fine
//    //namedWindow("imageROI");
//    imshow("imageROI2", imgROI1);
//    imshow("imageROI1", imgROI2);
//    
//    imshow("90RO", rotated90);
//
//    //namedWindow("practice image");
//    imshow("practice image", practice1);
//
//
//    waitKey();
//    return 0;
//}