#include <opencv2/opencv.hpp>
#include <math.h>
#include <stdio.h>


using namespace cv;


int mai-n(int argc, char *argv[])
{
    // read image
    Mat img = imread(argv[1], IMREAD_GRAYSCALE); // check release or debug
   

   //rotate 90 degrees clockwise
    Mat rotateClockwise90(Size(img.cols, img.rows), CV_8UC1);
    Mat rotateAntiCwise90(Size(img.cols, img.rows), CV_8UC1);


    // clockwise 90 degrees
    for (int j = 0; j < img.rows; j++)
    {
        for (int i = 0; i < img.cols; i++)
        {
            rotateClockwise90.at<uchar>(i, img.rows - 1 - j) = img.at<uchar>(j, i);
            
        }
    }
    

    // anti-clockwise 90 degrees ( clockwise 270 degrees)
    for (int j = 0; j < img.rows; j++)
    {
        for (int i = 0; i < img.cols; i++)
        {
            rotateAntiCwise90.at<uchar>(img.rows - 1 - i, j) = img.at<uchar>(j, i);

        }
    }


    imshow("image", img);
    imshow("clockwise 90", rotateClockwise90);
    imshow("anti-clockwise 90", rotateAntiCwise90);

    waitKey(0);
    return 0;
} 