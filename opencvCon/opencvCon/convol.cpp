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
Mat multiplyConv(Mat image, Mat paddedImage, MatrixValues kernel, int strides, char *argv);


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
    Mat conved = multiplyConv(srcImage, padded, kernel, strides, argv[4]);

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
        for (int i = 0; i < image.rows; i++)
        {
            for (int j = 0; j < image.cols; j++)
            {
                paddedImage.at<uchar>(i + paddRow, j + paddCol) = image.at<uchar>(i, j);
            }
        }

        argv = _strupr(argv);
        printf("%s\n", argv);


        return paddedImage;
    }
    if ((_stricmp(argv, "VALID")) == 0)
    {
        argv = _strupr(argv);
        return image;
    }
}

Mat multiplyConv(Mat image, Mat paddedImage, MatrixValues kernel, int strides, char *argv)
{
    Mat convImage;


    if ((_stricmp(argv, "VALID")) == 0)
    {

        convImage = Mat::zeros(Size(image.cols - (kernel.col - 1), image.rows - (kernel.col - 1)), CV_8UC1);
        
        argv = _strupr(argv);
        printf("valid rows x cols : %d x %d\n", convImage.rows, convImage.cols);
        //printf("%s\n", argv);d
        for (int i = 0; i < convImage.rows; i += strides)
        {
            for (int j = 0; j < convImage.cols; j += strides)
            {
                int convValue = 0;
                for (int k = 0; k < kernel.row; k++)
                {
                    for (int l = 0; l < kernel.col; l++)
                    {
                        convValue += image.at<uchar>(i + k, j + l) * (kernel.mat[k * kernel.col + l]);
                    }
                }
                convImage.at<uchar>(i, j) = convValue;
            }
        }

        return convImage;
    }


    convImage = Mat::zeros(Size(paddedImage.cols, paddedImage.rows), CV_8UC1);
    for (int i = 0; i < image.rows; i += strides)
    {
        for (int j = 0; j < image.cols; j+= strides)
        {
            int convValue = 0;
            for (int k = 0; k < kernel.row; k++)
            {
                for (int l = 0; l < kernel.col; l++)
                {
                    convValue += paddedImage.at<uchar>(i + k, j + l) * (kernel.mat[k * kernel.col + l]);
                }
            }
            convImage.at<uchar>(i, j) = convValue;
        }
    }

    return convImage;
}