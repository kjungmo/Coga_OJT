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

typedef enum PaddingMode
{
    same = 100,
    valid = 200
} PaddingMode;

using namespace cv;
using namespace std;

MatrixValues createKernel(char *file);
Mat applyPadding(Mat srcimage, int padding, MatrixValues kernel);
Mat multiplyConv(Mat image, Mat paddedImage, MatrixValues kernel, int strides, int padding);


int main(int argc, char *argv[])
{
    // get image
    Mat srcImage = imread(argv[1], IMREAD_GRAYSCALE);
    if (srcImage.empty())
    {
        printf("Image read ERROR\n");
        exit(0);
    }

    PaddingMode padding;
    if ((_stricmp(argv[4], "VALID") == 0))
    {
        padding = valid;
    }
    else if ((_stricmp(argv[4], "SAME") == 0))
    {
        padding = same;
    }
    printf("padding : %d\n", padding);

    // create kernel
    MatrixValues kernel;
    kernel = createKernel(argv[2]);

    // padding applyment
    Mat padded = applyPadding(srcImage, padding, kernel);
    
    // convolution multiplication
    int strides = atoi(argv[3]);
    Mat conved = multiplyConv(srcImage, padded, kernel, strides, padding);

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

Mat applyPadding(Mat image, int padding, MatrixValues kernel)
{

    if (padding == 200)
    {
        return image;
    }
    else // same
    {
        Mat paddedImage;
        int paddRow = kernel.row / 2;
        int paddCol = kernel.col / 2;
        paddedImage.rows = image.rows + kernel.row - 1;
        paddedImage.cols = image.cols + kernel.col - 1;
        //printf("padded rows X cols : %d X %d\n", paddedImage.rows, paddedImage.cols);
        paddedImage = Mat::zeros(paddedImage.rows, paddedImage.cols, CV_8UC1);
        for (int i = 0; i < image.rows; i++)
        {
            for (int j = 0; j < image.cols; j++)
            {
                paddedImage.at<uchar>(i + paddRow, j + paddCol) = image.at<uchar>(i, j);
            }
        }

        return paddedImage;
    }

}

Mat multiplyConv(Mat image, Mat paddedImage, MatrixValues kernel, int strides, int padding)
{
    Mat convImage;
    Mat paddOrNot;

    if (padding == 200)
    {
        convImage = Mat::zeros(Size(image.cols - (kernel.col - 1), image.rows - (kernel.col - 1)), CV_8UC1);
        paddOrNot = applyPadding(image, padding, kernel);
    }
    else // same
    {
        convImage = Mat::zeros(Size(image.cols, image.rows), CV_8UC1);
        paddOrNot = applyPadding(image, padding, kernel);
    }

    // convolution multiplication
    for (int i = 0; i < convImage.rows; i += strides)
    {
        for (int j = 0; j < convImage.cols; j += strides)
        {
            int convValue = 0;
            for (int k = 0; k < kernel.row; k++)
            {
                for (int l = 0; l < kernel.col; l++)
                {
                    convValue += paddOrNot.at<uchar>(i + k, j + l) * (kernel.mat[k * kernel.col + l]);
                }
            }

            if (convValue < 0)
            {
                convValue = abs(convValue);
            }
            else if ( convValue > 255) convValue -= 255;

            //printf("%d ", convValue);
            convImage.at<uchar>(i, j) = convValue;
        }
    }

    return convImage;
}