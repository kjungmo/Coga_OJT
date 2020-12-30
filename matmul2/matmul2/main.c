#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct MatrixValues{
    int row;
    int col;
    int *mat;
    char *filename;
}MatrixValues;

MatrixValues multiplyMatrix(MatrixValues, MatrixValues);
MatrixValues createMatrix(char*);
void printMatrix(MatrixValues);
void freeMatrix(MatrixValues);


int main(int argc, char *argv[])
{
    // when argument values are less than 3
    if (argc < 3)
    {
        printf("Error. \n");
    }

    else
    {
        MatrixValues frontMatrix, rearMatrix, resultMatrix;
        frontMatrix = createMatrix(argv[1]);
        printMatrix(frontMatrix);

        for (int i = 2; i < argc; i++)
        {
            rearMatrix = createMatrix(argv[i]);
            printMatrix(rearMatrix);

            resultMatrix = multiplyMatrix(frontMatrix, rearMatrix);
            //if (resultMatrix.mat == NULL) exit(1);
            printMatrix(resultMatrix);

            freeMatrix(frontMatrix);
            freeMatrix(rearMatrix);
            
            frontMatrix = resultMatrix;
        }
        freeMatrix(resultMatrix);
    }
    return 0;
}


//multiplies two matrices and returns MatrixValues( includes row, col, **mat)
MatrixValues multiplyMatrix(MatrixValues matrixA, MatrixValues matrixB)
{
    int sum, i, j, k;
    MatrixValues matrixAB = { 0 };
    

    if (matrixA.col != matrixB.row)
    {
        printf("Error\n");
        exit(0);
        //*matrixAB.mat = NULL;
    }
       
    matrixAB.row = matrixA.row;
    matrixAB.col = matrixB.col;
    matrixAB.mat = (int*)malloc(sizeof(int) * (matrixAB.row * matrixAB.col));
    matrixAB.filename = strcat(matrixA.filename, matrixB.filename);

    for (i = 0; i < matrixA.row; i++)
    {
        for (j = 0; j < matrixB.col; j++)
        {
            sum = 0;
            for (k = 0; k < matrixB.row; k++)
            {
                sum += matrixA.mat[i * matrixA.row + k] * matrixB.mat[k + j * matrixB.col];
            }
            matrixAB.mat[i * matrixAB.row + j] = sum;
        }
    }
    return matrixAB;
}

// creates matrix and returns MatrixValues(includes row, col, **mat)
MatrixValues createMatrix(char *file)
{
    MatrixValues matrix = { 0 };
    int i, j;

    // start filestream
    FILE *f;
    f = fopen(file, "r");
    fscanf(f, "%d%d", &matrix.row, &matrix.col);
    matrix.filename = strtok(file, ".");

    // allocate memory for matrix
    matrix.mat = (int*)malloc(sizeof(int) * (matrix.row * matrix.col));
    for (i = 0; i < matrix.row; i++)
    {
        for (j = 0; j < matrix.col; j++)
        {
            fscanf(f, "%d", &matrix.mat[i * matrix.row + j]);
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
            printf("%d ", matrix.mat[i * matrix.row + j]);
        }
        printf("\n");
    }
}

void freeMatrix(MatrixValues matrix)
{
    free(matrix.mat);
}