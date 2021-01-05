#include "opencv2/opencv.hpp"
#include <iostream>
#include <math.h>
#include <cmath>

#define PI 3.1415926535897

using namespace cv;
using namespace std;

struct Coords{
    double x = 0.0;
    double y = 0.0;
};
struct Length {
    int w;
    int h;
};
Mat forward(Mat image, int degree);
Mat backward(Mat image, int degree);
Mat forwardFitted(Mat image, int degree);
Mat backwardFitted(Mat image, int degree);
double bilinearIntPol(const Coords& p, Mat image);
Length getImageSize(Mat image, int degree);


int main(int argc, char *argv[])
{
    // read image
    Mat sourceImage = imread(argv[1], IMREAD_GRAYSCALE); // check release or debug
   
   // get degrees
   int degree = atoi(argv[2]);
   printf("Image has been %d degrees rotated", degree);
   printf("\n");

   // get rotated Image
   Mat rotatedForward = forward(sourceImage, degree);
   Mat rotatedBackward = backward(sourceImage, degree);
   Mat rotateFwdFit = forwardFitted(sourceImage, degree);
   Mat rotateBwdFit = backwardFitted(sourceImage, degree);

   imshow("source Image", sourceImage);
   imshow("[FORWARD]rotated Image", rotatedForward);
   imshow("[BACKWARD]rotated Image", rotatedBackward);
   imshow("[fwdFIT]rotated Image", rotateFwdFit);
   imshow("[bwdFIT]rotated Image", rotateBwdFit);
   
    waitKey(0);
    return 0;
} 

Mat forward(Mat image, int degree)
{
    int W, H;
    W = image.cols;
    H = image.rows;

    int centerX = W / 2;
    int centerY = H / 2;

    double theta = degree * (PI / 180);

    Mat targetImage;
    targetImage = Mat::zeros(image.rows, image.cols, CV_8UC1);

    for (int x = 0; x < targetImage.cols; x++)
    {
        for (int y = 0; y < targetImage.rows; y++)
        {

            int newX = (int)(cos(theta) * (x - centerX) + sin(theta) * (y - centerY) + centerX);
            int newY = (int)(-sin(theta) * (x - centerX) + cos(theta) * (y - centerY) + centerY);

            if (newX < 0)            continue;
            if (newX >= image.cols)  continue;
            if (newY < 0)            continue;
            if (newY >= image.rows)  continue;

            targetImage.at<uchar>(newY, newX) = image.at<uchar>(y, x);
        }
    }

    return targetImage;
}

Mat backward(Mat image, int degree)
{
    int W, H;
    W = image.cols;
    H = image.rows;

    int centerX = W / 2;
    int centerY = H / 2;

    double theta = -degree * (PI / 180);

    Mat targetImage;
    targetImage = Mat::zeros(image.rows, image.cols, CV_8UC1);

    for (int x = 0; x < targetImage.cols; x++)
    {
        for (int y = 0; y < targetImage.rows; y++)
        {

            int newX = (int)(cos(theta) * (x - centerX) + sin(theta) * (y - centerY) + centerX);
            int newY = (int)(-sin(theta) * (x - centerX) + cos(theta) * (y - centerY) + centerY);

            if (newX < 0)            continue;
            if (newX >= image.cols)  continue;
            if (newY < 0)            continue;
            if (newY >= image.rows)  continue;

            targetImage.at<uchar>(y, x) = image.at<uchar>(newY, newX);
        }
    }

    return targetImage;
}

Mat forwardFitted(Mat image, int degree)
{
    int H, W;
    W = image.cols;
    H = image.rows;

    int centerX = W / 2;
    int centerY = H / 2;

    double theta = degree * (PI / 180);

    Length rotated = getImageSize(image, degree);
    printf("rotated W X H = %d X %d\n", rotated.w, rotated.h);

    int rotatedCenterX = rotated.w / 2;
    int rotatedCenterY = rotated.h / 2;

    int movedCenterX = rotatedCenterX - centerX;
    int movedCenterY = rotatedCenterY - centerY;

    Mat tempImage;
    tempImage = Mat::zeros(Size(rotated.w, rotated.h), CV_8UC1);
    Mat targetImage;
    targetImage = Mat::zeros(Size(rotated.w, rotated.h), CV_8UC1);

    for (int i = 0; i < W; i++)
    {
        for (int j = 0; j < H; j++)
        {
            tempImage.at<char>(j + movedCenterX, i + movedCenterY) = image.at<uchar>(j, i);
        }
    }
    
    for (int x = 0; x < targetImage.cols; x++)
    {
        for (int y = 0; y < targetImage.rows; y++)
        {
            
            int newX = (int)(cos(theta) * (x - rotatedCenterX) + sin(theta) * (y - rotatedCenterY) + rotatedCenterX);
            int newY = (int)(-sin(theta) * (x - rotatedCenterX) + cos(theta) * (y - rotatedCenterY) + rotatedCenterY);
            
            if(newX < 0 || newX > rotated.w - 1)  continue;
            else if(newY < 0 || newY > rotated.h - 1)  continue;
            
            targetImage.at<uchar>(newY, newX) = tempImage.at<uchar>(y, x);
        }
    }

    return targetImage;
}

Mat backwardFitted(Mat image, int degree)
{
    int H, W;
    W = image.cols;
    H = image.rows;

    int centerX = W / 2;
    int centerY = H / 2;
    
    double theta = -degree * (PI / 180);
   
    Length rotated = getImageSize(image, degree);
    printf("rotated W X H = %d X %d\n", rotated.w, rotated.h);

    int rotatedCenterX = rotated.w / 2;
    int rotatedCenterY = rotated.h / 2;

    int movedCenterX = rotatedCenterX - centerX;
    int movedCenterY = rotatedCenterY - centerY;

    Mat tempImage;
    tempImage = Mat::zeros(Size(rotated.w, rotated.h), CV_8UC1);
    Mat targetImage;
    targetImage = Mat::zeros(Size(rotated.w, rotated.h), CV_8UC1);

    for (int i = 0; i < W; i++)
    {
        for (int j = 0; j < H; j++)
        {
            tempImage.at<char>(j + movedCenterX, i + movedCenterY) = image.at<uchar>(j, i);
        }
    }

    for (int x = 0; x < targetImage.cols; x++)
    {
        for (int y = 0; y < targetImage.rows; y++)
        {

            double newX = (cos(theta) * (x - rotatedCenterX) + sin(theta) * (y - rotatedCenterY) + rotatedCenterX);
            double newY = (-sin(theta) * (x - rotatedCenterX) + cos(theta) * (y - rotatedCenterY) + rotatedCenterY);

            if (newX < 0 || newX > rotated.w - 1)  continue;
            else if (newY < 0 || newY > rotated.h - 1)  continue;
            Coords newXY;
            newXY.x = newX;
            newXY.y = newY;
            targetImage.at<uchar>(y, x) = bilinearIntPol(newXY, tempImage);
        }
    }

    return targetImage;
}

double bilinearIntPol(const Coords& p, Mat image)
{
    double mu = p.x - floor(p.x);
    double lambda = p.y - floor(p.y);
    
    Coords A;
    A.x = (int)floor(p.x);
    A.y = (int)floor(p.y);
    Coords B;
    B.x = A.x;
    B.y = A.y + 1;
    Coords C;
    C.x = A.x + 1;
    C.y = A.y;
    Coords D;
    D.x = A.x + 1;
    D.y = A.y + 1;

    // right side ( B, D out)
    // .y no prob but B.x out D.x out
    if ( B.x > image.cols - 1 ) return lambda * image.at<uchar>(C.y, C.x) + (1 - lambda) * image.at<uchar>(A.y, A.x);
    
    // lower side ( C, D out)
    // .x no prob but C.y out D.y out
    if ( C.y > image.rows -1 ) return mu * image.at<uchar>(B.y, B.x) + (1 - mu) * image.at<uchar>(A.y, A.x);

    // lower right side( B, C, D out)
    if ( B.x > image.cols -1 && C.y > image.rows -1 ) return image.at<uchar>(A.y, A.x);

    int pixelA = image.at<uchar>(A.y, A.x);
    int pixelB = image.at<uchar>(B.y, B.x);
    int pixelC = image.at<uchar>(C.y, C.x);
    int pixelD = image.at<uchar>(D.y, D.x);

    double pixelE = mu * pixelB + (1 - mu) * pixelA;
    double pixelF = mu * pixelD + (1 - mu) * pixelC;

    double pixelN = lambda * pixelF + (1 - lambda) * pixelE;

    return pixelN;
}

Length getImageSize(Mat image,int degree)
{
    int W, H;
    W = image.cols;
    H = image.rows;

    int centerX = W / 2;
    int centerY = H / 2;
    
    Coords A;
    A.x = image.cols - image.cols;
    A.y = image.rows - image.rows;
    Coords B;
    B.x = A.x;
    B.y = A.y + image.rows;
    Coords C;
    C.x = A.x + image.cols;
    C.y = A.y;
    Coords D;
    D.x = A.x + image.cols;
    D.y = A.y + image.rows;

    double theta = degree * (PI / 180);

    double newAX = cos(theta) * (A.x - centerX) + sin(theta) * (A.y - centerY) + centerX;
    double newAY = -sin(theta) * (A.x - centerX) + cos(theta) * (A.y - centerY) + centerY;
    double newBX = cos(theta) * (B.x - centerX) + sin(theta) * (B.y - centerY) + centerX;
    double newBY = -sin(theta) * (B.x - centerX) + cos(theta) * (B.y - centerY) + centerY;
    double newCX = cos(theta) * (C.x - centerX) + sin(theta) * (C.y - centerY) + centerX;
    double newCY = -sin(theta) * (C.x - centerX) + cos(theta) * (C.y - centerY) + centerY;
    double newDX = cos(theta) * (D.x - centerX) + sin(theta) * (D.y - centerY) + centerX;
    double newDY = -sin(theta) * (D.x - centerX) + cos(theta) * (D.y - centerY) + centerY;

    int newWidth = abs(newBX - newCX);
    int newHeight = abs(newAY - newDY);

    Length newOne;
    newOne.w = newWidth;
    newOne.h = newHeight;

    return newOne;
}