#define _CRT_SECURE_NO_WARNINGS
#include <opencv2/opencv.hpp>
#include <math.h>
#include <stdio.h>

#define PI 3.1415926535897

using namespace std;
using namespace cv;

double getRadian(int _num)
{
    return _num * ( PI / 180);
}



int main()
{
    // read image
    Mat img = imread("a.jpg");
    Mat gray;

    cvtColor(img, gray, COLOR_BGR2GRAY);

    namedWindow("display window", WINDOW_AUTOSIZE);
    imshow("display window", img);

    namedWindow("gray window", WINDOW_AUTOSIZE);
    imshow("gray window", gray);

    int W, H;
    W = gray.rows;
    H = gray.cols;
    printf("image size : %d X %d \n", W, H);


    int row1, row2;
    printf("rows of which pixel values >>");
    scanf("%d %d", &row1, &row2);
    printf("\n row%d to row%d pixel values >> \n", row1, row2);
    for (int i = row1; i <= row2; i++)
    {
        printf("<row %d> \n", i);
        for (int j = 0; j < H; j++)
        {
            printf("%d ", gray.at<uchar>(i,j));
        }
        printf("\n \n");
    }
    double result1, result2, result3;

    double num = getRadian(90);

    result1 = sin(num);
    result2 = cos(num);
    result3 = tan(num);

    printf("sin90 : %lf\n", result1);
    printf("cos90 : %lf\n", result2);
    printf("tan90 : %lf\n", result3);

    //img.at<uchar>(x, y);

    waitKey(0);

    

    return 0;
} 