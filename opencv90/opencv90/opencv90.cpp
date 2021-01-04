#include "opencv2/opencv.hpp"
#include <iostream>
#include <math.h>

#define PI 3.1415926535897

using namespace cv;
using namespace std;

Mat forward(Mat image, int degree);
Mat backward(Mat image, int degree);

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


   imshow("source Image", sourceImage);
   imshow("[FORWARD]rotated Image", rotatedForward);
   imshow("[BACKWARD]rotated Image", rotatedBackward);
   
    waitKey(0);
    return 0;
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
            
            if(newX < 0)            continue;
            if(newX >= image.cols)  continue;
            if(newY < 0)            continue;
            if(newY >= image.rows)  continue;
            
            targetImage.at<uchar>(newY, newX) = image.at<uchar>(y, x);
        }
    }

    return targetImage;
}
