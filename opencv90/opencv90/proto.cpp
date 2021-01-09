//#include "opencv2/opencv.hpp"
//#include <iostream>
//#include <math.h>
//
//#define PI 3.1415926535897
//
//using namespace cv;
//using namespace std;
////
////Mat forward(Mat image, int degree);
////Mat backward(Mat image, int degree);
////Mat forwardFitted(Mat image, int degree);
//Mat backwardFitted(Mat image, int degree);
//
//int main(int argc, char *argv[])
//{
//    // read image
//    Mat sourceImage = imread(argv[1], IMREAD_GRAYSCALE); // check release or debug
//
//   // get degrees
//    int degree = atoi(argv[2]);
//    printf("Image has been %d degrees rotated", degree);
//    printf("\n");
//
//    // get rotated Image
//    /*Mat rotatedForward = forward(sourceImage, degree);
//    Mat rotatedBackward = backward(sourceImage, degree);
//    Mat rotateFwdFit = forwardFitted(sourceImage, degree);*/
//    Mat rotateBwdFit = backwardFitted(sourceImage, degree);
//
//    imshow("source Image", sourceImage);
//    /*imshow("[FORWARD]rotated Image", rotatedForward);
//    imshow("[BACKWARD]rotated Image", rotatedBackward);
//    imshow("[fwdFIT]rotated Image", rotateFwdFit);*/
//    imshow("[bwdFIT]rotated Image", rotateBwdFit);
//
//    waitKey(0);
//    return 0;
//}
//
//Mat forward(Mat image, int degree)
//{
//    int W, H;
//    W = image.cols;
//    H = image.rows;
//
//    int centerX = W / 2;
//    int centerY = H / 2;
//
//    double theta = degree * (PI / 180);
//
//    Mat targetImage;
//    targetImage = Mat::zeros(image.rows, image.cols, CV_8UC1);
//
//    for (int x = 0; x < targetImage.cols; x++)
//    {
//        for (int y = 0; y < targetImage.rows; y++)
//        {
//
//            int newX = (int)(cos(theta) * (x - centerX) + sin(theta) * (y - centerY) + centerX);
//            int newY = (int)(-sin(theta) * (x - centerX) + cos(theta) * (y - centerY) + centerY);
//
//            if (newX < 0)            continue;
//            if (newX >= image.cols)  continue;
//            if (newY < 0)            continue;
//            if (newY >= image.rows)  continue;
//
//            targetImage.at<uchar>(newY, newX) = image.at<uchar>(y, x);
//        }
//    }
//
//    return targetImage;
//}
////
////Mat backward(Mat image, int degree)
////{
////    int W, H;
////    W = image.cols;
////    H = image.rows;
////
////    int centerX = W / 2;
////    int centerY = H / 2;
////
////    double theta = -degree * (PI / 180);
////
////    Mat targetImage;
////    targetImage = Mat::zeros(image.rows, image.cols, CV_8UC1);
////
////    for (int x = 0; x < targetImage.cols; x++)
////    {
////        for (int y = 0; y < targetImage.rows; y++)
////        {
////
////            int newX = (int)(cos(theta) * (x - centerX) + sin(theta) * (y - centerY) + centerX);
////            int newY = (int)(-sin(theta) * (x - centerX) + cos(theta) * (y - centerY) + centerY);
////
////            if (newX < 0)            continue;
////            if (newX >= image.cols)  continue;
////            if (newY < 0)            continue;
////            if (newY >= image.rows)  continue;
////
////            targetImage.at<uchar>(y, x) = image.at<uchar>(newY, newX);
////            //targetImage.at<uchar>(newY, newX) = image.at<uchar>(y, x);
////        }
////    }
////
////    return targetImage;
////}
////
////Mat forwardFitted(Mat image, int degree)
////{
////    int H, W;
////    W = image.cols;
////    H = image.rows;
////
////    double theta = degree * (PI / 180);
////    double minusTheta = (90 - degree) * PI / 180;
////    printf("cos(minusTheta) : %lf\n", cos(minusTheta));
////    printf("cos(theta) : %lf\n", cos(theta));
////
////    int centerX = W / 2;
////    int centerY = H / 2;
////
////    int rotatedW = H * cos(minusTheta) + W * cos(theta);
////    int rotatedH = H * cos(theta) + W * cos(minusTheta);
////    printf("rotated W X H = %d X %d\n", rotatedW, rotatedH);
////
////    int rotatedCenterX = rotatedW / 2;
////    int rotatedCenterY = rotatedH / 2;
////
////    int movedCenterX = rotatedCenterX - centerX;
////    int movedCenterY = rotatedCenterY - centerY;
////
////    Mat tempImage;
////    tempImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);
////    Mat targetImage;
////    targetImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);
////
////    for (int i = 0; i < W; i++)
////    {
////        for (int j = 0; j < H; j++)
////        {
////            tempImage.at<char>(j + movedCenterX, i + movedCenterY) = image.at<uchar>(j, i);
////        }
////    }
////
////    for (int x = 0; x < targetImage.cols; x++)
////    {
////        for (int y = 0; y < targetImage.rows; y++)
////        {
////
////            int newX = (int)(cos(theta) * (x - rotatedCenterX) + sin(theta) * (y - rotatedCenterY) + rotatedCenterX);
////            int newY = (int)(-sin(theta) * (x - rotatedCenterX) + cos(theta) * (y - rotatedCenterY) + rotatedCenterY);
////
////            if (newX < 0 || newX >= rotatedW)  continue;
////            else if (newY < 0 || newY >= rotatedH)  continue;
////
////            targetImage.at<uchar>(newY, newX) = tempImage.at<uchar>(y, x);
////        }
////    }
////
////    return targetImage;
////}
//
//Mat backwardFitted(Mat image, int degree)
//{
//    int H, W;
//    W = image.cols;
//    H = image.rows;
//
//    double theta = -degree * (PI / 180);
//    double minusTheta = (90 - degree) * PI / 180;
//
//    int centerX = W / 2;
//    int centerY = H / 2;
//
//    int rotatedW = H * cos(minusTheta) + W * cos(theta);
//    int rotatedH = H * cos(theta) + W * cos(minusTheta);
//    printf("rotated W X H = %d X %d\n", rotatedW, rotatedH);
//
//    int rotatedCenterX = rotatedW / 2;
//    int rotatedCenterY = rotatedH / 2;
//
//    int movedCenterX = rotatedCenterX - centerX;
//    int movedCenterY = rotatedCenterY - centerY;
//
//    Mat tempImage;
//    tempImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);
//    Mat targetImage;
//    targetImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);
//
//    for (int i = 0; i < W; i++)
//    {
//        for (int j = 0; j < H; j++)
//        {
//            tempImage.at<char>(j + movedCenterX, i + movedCenterY) = image.at<uchar>(j, i);
//        }
//    }
//
//    for (int x = 0; x < targetImage.cols; x++)
//    {
//        for (int y = 0; y < targetImage.rows; y++)
//        {
//
//            int newX = (int)(cos(theta) * (x - rotatedCenterX) + sin(theta) * (y - rotatedCenterY) + rotatedCenterX);
//            int newY = (int)(-sin(theta) * (x - rotatedCenterX) + cos(theta) * (y - rotatedCenterY) + rotatedCenterY);
//
//            if (newX < 0 || newX >= rotatedW)  continue;
//            else if (newY < 0 || newY >= rotatedH)  continue;
//
//            targetImage.at<uchar>(y, x) = tempImage.at<uchar>(newY, newX);
//        }
//    }
//
//    return targetImage;
//}