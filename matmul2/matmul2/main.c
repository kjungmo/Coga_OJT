#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct MatrixValues{
    int row;
    int col;
    int **mat;
    char *filename;
    struct MatrixValues* swap;

}MatrixValues;

MatrixValues MatMul(MatrixValues, MatrixValues);
MatrixValues createMatrix(char*);
void printMatrix(MatrixValues);
void freeMatrix(MatrixValues);
void swapMatrix(MatrixValues*, MatrixValues *);

int main(int argc, char *argv[])
{
    // when argument values are less than 3
    if (argc < 3)
    {
        printf("Error. \n");
    }

    else
    {
        MatrixValues Matrix_front, Matrix_rear, Matrix_result;
        for (int i = 1; i < argc; i++)
        {
            if ( i == 1)
            {
                Matrix_front = createMatrix(argv[i]);
                printMatrix(Matrix_front);
                continue;
            }
            

            Matrix_rear = createMatrix(argv[i]);
            printMatrix(Matrix_rear);

            Matrix_result = MatMul(Matrix_front, Matrix_rear);
            printMatrix(Matrix_result);

            

            //swap values
            swapMatrix(&Matrix_result, &Matrix_front);

            //free Memory allocation
            freeMatrix(Matrix_rear);
            freeMatrix(Matrix_result);
        }
        
        freeMatrix(Matrix_front);
    }
    return 0;
}


//multiplies two matrices and returns MatrixValues( includes row, col, **mat)
MatrixValues MatMul(MatrixValues matrixA, MatrixValues matrixB)
{
    if (matrixA.col != matrixB.row)
    {
        printf("Error\n");
        exit(0);
    }

    int sum, i, j, k;
    MatrixValues matrixAB = { 0 };
    matrixAB.row = matrixA.row;
    matrixAB.col = matrixB.row;
    matrixAB.mat = (int**)malloc(sizeof(int*) * matrixAB.row);
    matrixAB.filename = strcat(matrixA.filename, matrixB.filename);

    for (i = 0; i < matrixAB.row; i++)
    {
        *(matrixAB.mat + i) = (int*)malloc(sizeof(int) * matrixAB.col);
    }
    
    for (i = 0; i < matrixA.row; i++)
    {
        for (j = 0; j < matrixB.col; j++)
        {
            sum = 0;
            for (k = 0; k < matrixB.row; k++)
            {
                sum += matrixA.mat[i][k] * matrixB.mat[k][j];
            }
            matrixAB.mat[i][j] = sum;
        }
    }
    return matrixAB;
}

// creates matrix and returns MatrixValues(includes row, col, **mat)
MatrixValues createMatrix(char *argv)
{
    MatrixValues matrix = { 0 };
    int i, j;

    // start filestream
    FILE *f;
    f = fopen(argv, "r");
    fscanf(f, "%d%d", &matrix.row, &matrix.col);
    matrix.filename = strtok(argv, ".");

    // allocate memory for matrix
    matrix.mat = (int**)malloc(sizeof(int*) * matrix.row);
    for (i = 0; i < matrix.row; i++)
    {
        *(matrix.mat + i) = (int*)malloc(sizeof(int) * matrix.col);
    }

    // get & print values from matrix
    for (i = 0; i < matrix.row; i++)
    {
        for (j = 0; j < matrix.col; j++)
        {
            fscanf(f, "%d", &matrix.mat[i][j]);
        }
    }

    fclose(f);

    return matrix;
}

void printMatrix(MatrixValues matrix)
{
    int i, j;
    printf("%s = \n", matrix.filename);
    for (i = 0; i < matrix.row; i++)
    {
        for (j = 0; j < matrix.col; j++)
        {
            printf("%d ", matrix.mat[i][j]);
        }
        printf("\n");
    }
}

void freeMatrix(MatrixValues matrix)
{
    for (int i = 0; i < matrix.row; i++)
    {
        free(matrix.mat[i]);
    }
    free(matrix.mat);
}

void swapMatrix(MatrixValues *matrix1, MatrixValues *matrix2)
{
    MatrixValues temp;
    
    temp = *matrix1;
    *matrix1 = *matrix2;
    *matrix2 = temp;

}