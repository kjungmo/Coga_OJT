#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct MatrixValues{
    int row;
    int col;
    int **mat;
    char *filename;
}MatrixValues;


MatrixValues createMatrix(char *argv);
MatrixValues MatMul(MatrixValues a, MatrixValues b);
void printMatrix(MatrixValues a);

int main(int argc, char *argv[])
{
    
    if (argc < 3)
    {

        printf("Error. \n");

    }

    else if (argc == 3)
    {
        MatrixValues mat1, mat2, mat12;
        mat1 = createMatrix(argv[1]);
        printMatrix(mat1);
        mat2 = createMatrix(argv[2]);
        printMatrix(mat2);
        mat12 = MatMul(mat1, mat2);
        printMatrix(mat12);
 
    }

    // 명령행 인자가 4개 이상인 경우 (행렬 .txt파일이 3개 이상인 경우)
    else
    {
        //TODO 
        //행렬 txt가 3개 이상인 경우
        // 순차적으로 1번 2번 행렬을 곱하고 곱한 행렬 값을 메모리에 저장한다
        // 1번과 2번 행렬의 메모리를 free해주고
        // 3번 메모리 공간을 확보하고 값을 저장한다
        // 12곱과 3을 곱하고 123행렬 메모리 할당 + 값을 메모리에 저장한다
        // 12곱과 3의 메모리를 free

        // 이후에도 행렬이 존재한다면 같은 방식으로 
        // 곱이 존재한다면? 곱 메모리가 순차적으로 먼저 생기고, argv[i]를 이동시키면서 해당 행렬을 불러온다.




    }
    return 0;
}


//multiplies two matrices and returns MatrixValues( includes row, col, **mat)
MatrixValues MatMul(MatrixValues a, MatrixValues b)
{
    if (a.col != b.row)
    {
        printf("Error\n");
        exit(0);
    }
    int sum, i, j, k;
    MatrixValues matAB = { 0 };
    matAB.row = a.row;
    matAB.col = b.row;
    matAB.mat = (int**)malloc(sizeof(int*) * matAB.col);
    matAB.filename = strcat(a.filename,b.filename);
    for (i = 0; i < matAB.row; i++)
    {
        *(matAB.mat + i) = (int*)malloc(sizeof(int) * matAB.col);
    }
    
    for (i = 0; i < a.row; i++)
    {
        for (j = 0; j < b.col; j++)
        {
            sum = 0;
            for (k = 0; k < b.row; k++)
            {
                sum += a.mat[i][k] * b.mat[k][j];
            }
            matAB.mat[i][j] = sum;
        }
    }
    return matAB;
}

// creates matrix and returns MatrixValues(includes row, col, **mat)
MatrixValues createMatrix(char *argv)
{
    MatrixValues mat = { 0 };
    int i, j, k;

    // start filestream
    FILE *f;
    f = fopen(argv, "r");
    fscanf(f, "%d%d", &mat.row, &mat.col);
    mat.filename = strtok(argv, ".");

    // allocate memory for matrix
    mat.mat = (int**)malloc(sizeof(int*) * mat.row);
    for (i = 0; i < mat.row; i++)
    {
        *(mat.mat + i) = (int*)malloc(sizeof(int) * mat.col);
    }

    // get & print values from matrix
    for (i = 0; i < mat.row; i++)
    {
        for (j = 0; j < mat.col; j++)
        {
            fscanf(f, "%d", &mat.mat[i][j]);
        }
    }

    fclose(f);

    return mat;
}

void printMatrix(MatrixValues a)
{
    int i, j;
    printf("%s = \n", a.filename);
    for (i = 0; i < a.row; i++)
    {
        for (j = 0; j < a.col; j++)
        {
            printf("%d ", a.mat[i][j]);
        }
        printf("\n");
    }
}