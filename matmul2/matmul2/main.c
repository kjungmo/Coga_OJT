#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct MatrixValues{
    int row;
    int col;
    int **mat;
}MatrixValues;


MatrixValues MatMul(MatrixValues a, MatrixValues b);
MatrixValues createMatrix(char *argv[]);
FILE* fileStream(char *argv[]);
void fileClose(FILE *f);
int **createMatrixMul(char *argv1[], char *argv2[]);


int main(int argc, char *argv[])
{
    
    if (argc < 3)
    {

        printf("Error. \n");

    }

    else if (argc = 3)
    {
        MatrixValues mat1, mat2, mat12;
        mat1 = createMatrix(argv[1]);
        mat2 = createMatrix(argv[2]);
        mat12 = MatMul(mat1, mat2);
 
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




    ////////////////////////////////////////////////////////////////

    //int row, col, i, j, k, l;

    //// 명령행 인자로 들어오는 파일들로부터 함수 값 출력
    //
    //for (int i = 0; i + 1 < argc; i++)
    //{
    //	FILE *f  = fopen(argv[i + 1], "r");
    //	fscanf(f, "%d%d", &row, &col);
    //	//printf("%d %d\n", row, col);

    //	// 행렬 메모리 할당
    //	//int **mat;
    //	//*mat + i = (int**)malloc((sizeof(int*)) * row);

    //	int **mat = (int**)malloc((sizeof(int*)) * row);
    //	*mat = *mat + (i * row * col);

    //	for (j = 0; j < row; j++)
    //	{
    //		*(mat + j) = (int*)malloc(sizeof(int) * col);
    //	}
    //
    //	char *sliced = strtok(argv[i], ".");
    //	printf("%s = \n", sliced);

    //	//행렬 값 넣어서 출력
    //	for (k = 0; k < row; k++)
    //	{
    //		for (l = 0; l < col; l++)
    //		{
    //			fscanf(f, "%d", *(mat + k) + l);
    //			printf("%d ", *(*(mat + k) + l));
    //		}
    //		printf("\n");
    //	}
    //	printf("\n");
    //	fclose(f);
    //	

    //}



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
    for (i = 0; i < matAB.row; i++)
    {
        *(matAB.mat + i) = (int*)malloc(sizeof(int) * matAB.col);
    }
    printf("AB = \n");
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
            printf("%d ", matAB.mat[i][j]);
        }
        printf("\n");
    }
    return matAB;
}

// creates matrix and returns MatrixValues(includes row, col, **mat)
MatrixValues createMatrix(char *argv[])
{
    MatrixValues mat = { 0 };
    int i, j, k;

    // start filestream
    FILE *f;
    f = fopen(argv, "r");
    fscanf(f, "%d%d", &mat.row, &mat.col);
    char *sliced = strtok(argv, ".");
    printf("%s = \n", sliced);

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
            printf("%d ", mat.mat[i][j]);
        }
        printf("\n");
    }

    fclose(f);

    return mat;
}

FILE* fileStream(char *argv[])
{
    FILE *f;
    f = fopen(argv, "r");
    return f;
}

void fileClose(FILE *f)
{
    fclose(f);
}

int **createMatrixMul(char *argv1[], char *argv2[])
{
    int row1, col1, row2, col2, i, j, k;
    FILE *f1, *f2;

    // first Matrix
    //FILE *f1 = fopen(argv1, "r");

    f1 = fileStream(argv1);
    fscanf(f1, "%d%d", &row1, &col1);
    printf("%d X %d sized Matrix\n", row1, col1);

    int **mat1 = (int**)malloc((sizeof(int*) * row1));

    for (i = 0; i < row1; i++)
    {
        mat1[i] = (int*)malloc(sizeof(int) * col1);
    }

    char *sliced1 = strtok(argv1, ".");
    printf("%s = \n", sliced1);

    for (j = 0; j < row1; j++)
    {
        for (k = 0; k < col1; k++)
        {
            fscanf(f1, "%d", &mat1[j][k]);
            printf("%d ", mat1[j][k]);
        }
        printf("\n");
    }

    MatrixValues matrix1 = { row1, col1, mat1 };
    printf("values of matrix[0][1] : %d\n", mat1[0][1]);
    printf("sizeof struct MatrixValues : %d\n", sizeof(matrix1));
    printf("memory address of matrix1 : %p\n", matrix1);
    printf("memory address &: %p\n", &mat1);// mat is located in stack 
    printf("memory address : %p\n", mat1); // but malloc is in heap
    fileClose(f1);


    // second Matrix
    f2 = fopen(argv2, "r");
    fscanf(f2, "%d%d", &row2, &col2);
    printf("%d X %d sized Matrix\n", row2, col2);

    int **mat2 = (int**)malloc((sizeof(int*) * row2));

    for (i = 0; i < row2; i++)
    {
        mat2[i] = (int*)malloc(sizeof(int) * col2);
    }

    char *sliced2 = strtok(argv2, ".");
    printf("%s = \n", sliced2);

    for (j = 0; j < row2; j++)
    {
        for (k = 0; k < col2; k++)
        {
            fscanf(f2, "%d", &mat2[j][k]);
            printf("%d ", mat2[j][k]);
        }
        printf("\n");
    }

    MatrixValues matrix2 = { row2, col2, mat2 };
    printf("sizeof struct MatrixValues : %d\n", sizeof(matrix2));
    printf("memory address : %p\n", matrix2);
    printf("memory address &: %p\n", &mat2);// mat is located in stack 
    printf("memory address : %p\n", mat2); // but malloc is in heap
    fclose(f2);


    // check if the matrix multiplication can be further processed
    if (col1 != row2)
    {
        printf("Error\n");
        return 1;
    }

    int **matAB;
    matAB = (int**)malloc((sizeof(int*) * row1));

    for (i = 0; i < row1; i++)
    {
        matAB[i] = (int*)malloc(sizeof(int) * col2);
    }

    for (i = 0; i < row1; i++)
    {
        for (j = 0; j < col2; j++)
        {
            int sum = 0;
            for (k = 0; k < row2; k++)
            {
                sum += mat1[i][k] * mat2[k][j];
            }
            matAB[i][j] = sum;
            printf("%d ", matAB[i][j]);
        }
        printf("\n");
    }


    for (i = 0; i < row2; i++)
    {
        free(mat2[i]);
    }
    free(mat2);

    for (i = 0; i < row1; i++)
    {
        free(mat1[i]);
    }
    free(mat1);


    return matAB;

}

void printMatrix(int **mat)
{

}
