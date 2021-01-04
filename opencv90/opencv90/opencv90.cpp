#include "opencv2/opencv.hpp"
#include <iostream>
#include <math.h>

#define PI 3.1415926535897

using namespace cv;
using namespace std;

Mat getRotatedMatrix(Mat image, int degrees);
double getRadian(int _num);
int getNewX(int x, int y, int degrees);
int getNewY(int x, int y, int degrees);

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

    
    Mat targetImage(Size(image.rows, image.cols), CV_8UC1);


    for (int i = 0; i < targetImage.rows; i++)
    {
        for (int j = 0; j < targetImage.cols; j++)
        {
            targetImage.at<uchar>(i, j) = image.at<uchar>(getNewX(i, j, degrees), getNewY(i, j, degrees));
        }
    }

    return targetImage;
}

double getRadian(int _num)
{
    return _num * (PI / 180);
}

int getNewX(int x, int y, int degrees)
{
    int newX = (int)( (cos(getRadian(degrees)) * x) - (sin(getRadian(degrees)) * y) );
    return newX;
}

int getNewY(int x, int y, int degrees)
{
    int newY = (int)( (sin(getRadian(degrees)) * x) + (cos(getRadian(degrees)) * y) );
    return newY;
}
