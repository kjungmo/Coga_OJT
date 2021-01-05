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

Mat forward(Mat image, int degree);
Mat backward(Mat image, int degree);
Mat forwardFitted(Mat image, int degree);
Mat backwardFitted(Mat image, int degree);
double bilinearIntPol(const Coords& p, Mat image);


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
            //targetImage.at<uchar>(newY, newX) = image.at<uchar>(y, x);
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

    double theta = -degree * (PI / 180);

    if (degree > 90 && degree <= 180) degree = 180 - degree;
    if (degree > 180 && degree <= 270) degree = 270 - degree;
    if (degree > 270 && degree <= 360) degree = 360 - degree;

    double deltaFunc = degree * (PI / 180);
    double minusDeltaFunc = (90 - degree) * PI / 180;

    int rotatedW = H * cos(minusDeltaFunc) + W * cos(deltaFunc);
    int rotatedH = H * cos(deltaFunc) + W * cos(minusDeltaFunc);
    printf("rotated W X H = %d X %d\n", rotatedW, rotatedH);

    int rotatedCenterX = rotatedW / 2;
    int rotatedCenterY = rotatedH / 2;

    int movedCenterX = rotatedCenterX - centerX;
    int movedCenterY = rotatedCenterY - centerY;

    Mat tempImage;
    tempImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);
    Mat targetImage;
    targetImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);

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
            
            if(newX < 0 || newX >= rotatedW)  continue;
            else if(newY < 0 || newY >= rotatedH)  continue;
            
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
    
    if ( degree > 90 && degree <= 180) degree = 180 - degree;
    if ( degree > 180 && degree <= 270) degree = 270 - degree;
    if ( degree > 270 && degree <= 360) degree = 360 - degree;

    double deltaFunc = degree * (PI / 180);
    double minusDeltaFunc = (90 - degree) * PI / 180;

    int rotatedW = H * cos(minusDeltaFunc) + W * cos(deltaFunc);
    int rotatedH = H * cos(deltaFunc) + W * cos(minusDeltaFunc);
    printf("rotated W X H = %d X %d\n", rotatedW, rotatedH);

    int rotatedCenterX = rotatedW / 2;
    int rotatedCenterY = rotatedH / 2;

    int movedCenterX = rotatedCenterX - centerX;
    int movedCenterY = rotatedCenterY - centerY;

    Mat tempImage;
    tempImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);
    Mat targetImage;
    targetImage = Mat::zeros(Size(rotatedW, rotatedH), CV_8UC1);

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

            if (newX < 0 || newX >= rotatedW - 1)  continue;
            else if (newY < 0 || newY >= rotatedH - 1)  continue;
            Coords newXY;
            newXY.x = newX;
            newXY.y = newY;
            targetImage.at<uchar>(y, x) = bilinearIntPol(newXY, tempImage);
            //targetImage.at<uchar>(y, x) = tempImage.at<uchar>((int)newY, (int)newX);
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
    //if (A.x >= image.cols - 1) A.x = image.cols - 2;
    A.y = (int)floor(p.y);
    //if (A.y >= image.rows - 1) A.y = image.rows - 2;
    Coords B;
    B.x = A.x;
    B.y = A.y + 1;
    Coords C;
    C.x = A.x + 1;
    C.y = A.y;
    Coords D;
    D.x = A.x + 1;
    D.y = A.y + 1;

    // left side ( A, C out)
    // no prob

    // right side ( B, D out)
    // .y no prob but B.x out D.x out
    if ( B.x > image.cols - 1 && D.x > image.cols - 1) return image.at<uchar>(mu * C.y + (1 - mu) * A.y, mu * C.x + (1 - mu) * A.x);
    
    // upper side ( A, B out)
    // no prob
    
    // lower side ( C, D out)
    // .x no prob but C.y out D.y out
    if ( C.y > image.rows -1 && D.y > image.rows - 1) return image.at<uchar>(mu * B.y + (1 - mu) * A.y, mu * B.x + (1 - mu) * A.x);

    int pixelA = image.at<uchar>(A.y, A.x);
    int pixelB = image.at<uchar>(B.y, B.x);
    int pixelC = image.at<uchar>(C.y, C.x);
    int pixelD = image.at<uchar>(D.y, D.x);

    double pixelE = mu * pixelB + (1 - mu) * pixelA;
    double pixelF = mu * pixelD + (1 - mu) * pixelC;

    double pixelN = lambda * pixelF + (1 - lambda) * pixelE;

    return pixelN;
}

