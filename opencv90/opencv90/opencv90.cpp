#include "opencv2/opencv.hpp"
#include <iostream>
#include <math.h>

#define PI 3.1415926535897

using namespace cv;
using namespace std;

Mat getRotatedMatrix(Mat image, int degrees);
double getRadian(int _num);
int getNewX(Mat image, int x, int y, int degrees);
int getNewY(Mat image, int x, int y, int degrees);

int main(int argc, char *argv[])
{
    // read image
    Mat sourceImage = imread(argv[1], IMREAD_GRAYSCALE); // check release or debug
   
   // get degrees
   int degrees = atoi(argv[2]);

   // get rotated Image
   Mat rotatedImage = getRotatedMatrix(sourceImage, degrees);

   imshow("source Image", sourceImage);
   imshow("rotated Image", rotatedImage);
   
    waitKey(0);
    return 0;
} 

Mat getRotatedMatrix(Mat image, int degrees)
{
    int centerX = image.rows / 2;
    int centerY = image.cols / 2;
    
    
    Mat targetImage(Size(image.rows, image.cols), CV_8UC1);


    for (int i = 0; i < targetImage.rows; i++)
    {
        for (int j = 0; j < targetImage.cols; j++)
        {
            //targetImage.at<uchar>(i, j) = image.at<uchar>(getNewX(i, j, degrees), getNewY(i, j, degrees));
            int newX = getNewX(image, i, j, degrees);
            int newY = getNewY(image, i, j, degrees);
            
            if(newX < 0)            continue;
            if(newX >= image.cols)  continue;
            if(newY < 0)            continue;
            if(newY >= image.rows)  continue;

            targetImage.at<uchar>(newY,newX) = image.at<uchar>(i, j);
        }
    }

    return targetImage;
}

double getRadian(int _num)
{
    return _num * (PI / 180);
}

int getNewX(Mat image, int x, int y, int degrees)
{
    int centerX = image.cols / 2;
    int centerY = image.rows / 2;
    int newX = (int)(cos(getRadian(degrees)) * (x - centerX) - sin(getRadian(degrees)) * (y - centerY) + centerX );
    return newX;
}

int getNewY(Mat image, int x, int y, int degrees)
{
    int centerX = image.cols / 2;
    int centerY = image.rows / 2;
    int newY = (int)(sin(getRadian(degrees)) * (x - centerX) + cos(getRadian(degrees)) * (y - centerY) + centerY );
    return newY;
}
