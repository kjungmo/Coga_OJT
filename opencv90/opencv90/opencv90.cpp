#include "opencv2/opencv.hpp"
#include <iostream>
#include <math.h>

#define PI 3.1415926535897

using namespace cv;
using namespace std;

Mat getRotatedImage(Mat image, int degrees);

int main(int argc, char *argv[])
{
    // read image
    Mat sourceImage = imread(argv[1], IMREAD_GRAYSCALE); // check release or debug
   
   // get degrees
   int degrees = atoi(argv[2]);

   // get rotated Image
   Mat rotatedImage = getRotatedImage(sourceImage, degrees);

   imshow("source Image", sourceImage);
   imshow("rotated Image", rotatedImage);
   
    waitKey(0);
    return 0;
} 

Mat getRotatedImage(Mat image, int degrees)
{
    int W, H;
    W = image.cols;
    H = image.rows;
    int centerX = W / 2;
    int centerY = H / 2;
    //int seta = degrees * (PI / 180); // 180 anticlockwise // 40 clockwise(one function) 
    //int seta = (PI / 180) / degrees; // 90 clockwise
    int seta = degrees / (PI / 180); // holes, 30 anticlockwise
    
    Mat targetImage(Size(image.rows, image.cols), CV_8UC1);


    for (int i = 0; i < targetImage.rows; i++)
    {
        for (int j = 0; j < targetImage.cols; j++)
        {
            
            //targetImage.at<uchar>(i, j) = image.at<uchar>(getNewX(i, j, degrees), getNewY(i, j, degrees));
            int newX = (int)(cos(seta) * (i - centerX) + sin(seta) * (j - centerY) + centerX);
            int newY = (int)(-sin(seta) * (i - centerX) + cos(seta) * (j - centerY) + centerY);
            
            if(newX < 0)            continue;
            if(newX >= image.cols)  continue;
            if(newY < 0)            continue;
            if(newY >= image.rows)  continue;
            
            targetImage.at<uchar>(newX,newY) = image.at<uchar>(i, j);
        }
    }

    return targetImage;
}
