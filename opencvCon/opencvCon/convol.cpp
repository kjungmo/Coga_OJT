#define _CRT_SECURE_NO_WARNINGS
#include <opencv2/opencv.hpp>
#include <iostream>
#include <stdio.h>
#include <string.h>


typedef struct MatrixValues {
    int row;
    int col;
    int *mat;
}MatrixValues;

using namespace cv;
using namespace std;

MatrixValues createKernel(char *file);
Mat applyPadding(Mat srcimage, char *padding, MatrixValues kernel);
Mat multiplyConv(Mat srcimage, Mat paddedImage, MatrixValues kernel, int strides);


int main(int argc, char *argv[])
{
    // get image
    Mat srcImage = imread(argv[1], IMREAD_GRAYSCALE);

    // create kernel
    MatrixValues kernel;
    kernel = createKernel(argv[2]);

    // padding applyment
    Mat padded = applyPadding(srcImage, argv[4], kernel);
    
    // convolution multiplication
    int strides = atoi(argv[3]);
    Mat conved = multiplyConv(srcImage, padded, kernel, strides);

    imshow("conved", conved);
    waitKey();
    return 0;


}


MatrixValues createKernel(char *file)
{
    MatrixValues kernel = { 0 };
    int i, j;

    // start filestream
    FILE *f;
    f = fopen(file, "r");
    fscanf(f, "%d%d", &kernel.row, &kernel.col);

    // allocate memory for kernel
    kernel.mat = (int*)malloc(sizeof(int) * (kernel.row * kernel.col));
    for (i = 0; i < kernel.row; i++)
    {
        for (j = 0; j < kernel.col; j++)
        {
            fscanf(f, "%d", &kernel.mat[i * kernel.col + j]);
        }
    }

    fclose(f);

    return kernel;
}

Mat applyPadding(Mat image, char *argv, MatrixValues kernel)
{

    if ((_stricmp(argv, "SAME")) == 0)
    {
        Mat paddedImage;
        int paddRow = kernel.row / 2;
        int paddCol = kernel.col / 2;
        paddedImage.rows = image.rows + kernel.row - 1;
        paddedImage.cols = image.cols + kernel.col - 1;
        printf("padd rows X cols : %d X %d\n", paddedImage.rows, paddedImage.cols);
        paddedImage = Mat::zeros(paddedImage.rows, paddedImage.cols, CV_8UC1);
        for (int i = 0; i < image.cols; i++)
        {
            for (int j = 0; j < image.rows; j++)
            {
                paddedImage.at<uchar>(j + paddRow, i + paddCol) = image.at<uchar>(j, i);
            }
        }

        argv = _strupr(argv);
        printf("%s\n", argv);


        return paddedImage;
    }
    else if ((_stricmp(argv, "VALID")) == 0)
    {
        argv = _strupr(argv);
        printf("valid rows X cols : %d X %d\n", image.rows, image.cols);
        printf("%s\n", argv);
        return image;
    }
    else
    {
        printf("Padding mode missing\n");
        Mat null;

        return null;
    }
}

Mat multiplyConv(Mat image, Mat paddedImage, MatrixValues kernel, int strides)
{
    Mat convImage;
    convImage = Mat::zeros(Size(paddedImage.cols, paddedImage.rows), CV_8UC1);

    for (int i = 0; i < image.cols; i += strides)
    {
        for (int j = 0; j < image.rows; j+= strides)
        {
            int convValue = 0;
            for (int k = 0; k < kernel.col; k++)
            {
                for (int l = 0; l < kernel.row; l++)
                {
                    convValue += paddedImage.at<uchar>(j + l, i + k) * (kernel.mat[l + k * kernel.col]);
                }
            }
            convImage.at<uchar>(j, i) = convValue;
        }
    }

    return convImage;
}