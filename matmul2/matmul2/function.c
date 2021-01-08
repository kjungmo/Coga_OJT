#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>    
#include <string.h>

int main_(int argc, char *argv[])
{
    int row, col, i, j, k;

    FILE *f = fopen(argv[1], "r");
    fscanf(f, "%d%d", &row, &col);
    printf("%d X %d sized Matrix\n", row, col);

    int **mat = malloc(sizeof(int*) * row);

    for (i = 0; i < row; i++)
    {
        mat[i] = malloc(sizeof(int) * col);
    }

    char *sliced = strtok(argv[1], ".");
    printf("%s = \n", sliced);

    for (j = 0; j < row; j++)
    {
        for (k = 0; k < col; k++)
        {
            fscanf(f, "%d", &mat[j][k]);
            printf("%i ", mat[j][k]);
        }
        printf("\n");
    }
    printf("size of mat : %d\n",sizeof(&mat));
    //printf("size of mat[] : %d\n",sizeof(mat[0]));
    //printf("size of mat[][] : %d\n",sizeof(mat[0][0]));

    for (i = 0; i < row; i++)
    {
        free(mat[i]);
    }
    free(mat);
    //printf("memory address : %p\n", &mat);
    fclose(f);
    //free(mat); // temporary ( planning to make a function for free() )
    
    row = 0;
    for (i = 0; i < row;)
    while(mat[i] =! NULL) 
    {
        row += 1;
        printf("%d", row);
    }
    return 0;
}