#define _CRT_SECURE_NO_WARNINGS
#include <opencv2/opencv.hpp>
#include <iostream>
#include <stdio.h>

typedef struct MatrixValues {
    int row;
    int col;
    int *mat;
}MatrixValues;

using namespace cv;
using namespace std;

MatrixValues createKernel(char *file);
void printMatrix(MatrixValues matrix);

int main(int argc, char *argv[])
{
    Mat srcImage = imread(argv[1], IMREAD_GRAYSCALE);
    MatrixValues kernel;
    kernel = createKernel(argv[2]);
    printMatrix(kernel);





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

void printMatrix(MatrixValues matrix)
{
    int i, j;
    for (i = 0; i < matrix.row; i++)
    {
        for (j = 0; j < matrix.col; j++)
        {
            printf("%d ", matrix.mat[i * matrix.col + j]);
        }
        printf("\n");
    }
}
