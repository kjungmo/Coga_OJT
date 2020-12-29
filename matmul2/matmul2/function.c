#include <stdio.h>
#include <stdlib.h>    

int main()
{
    int num1 = 20;
    int *numPtr1;
    int **numPP1;

    numPtr1 = &num1;
    numPP1 = &numPtr1;

    int *numPtr2;
    int **numPP2;

    numPtr2 = malloc(sizeof(int));
    numPP2 = (int*)malloc(sizeof(int) * 2);

    printf("num1 address : %p\n", &num1);
    printf("numPtr1 address : %p\n", numPtr1); 
    printf("numPP1 address : %p\n", numPP1); 
    printf("\n");
    printf("size of numPtr1 : %i\n", sizeof(numPtr1));
    printf("size of *numPtr1 : %i\n", sizeof(*numPtr1));
    printf("size of numPP2 : %i\n", sizeof(numPP1));
    printf("size of *numPP2 : %i\n", sizeof(*numPP1));
    printf("size of **numPP2 : %i\n", sizeof(**numPP1));
    printf("\n");
    printf("numPtr2 address : %p\n", numPtr2); 
    printf("numPP2 address : %p\n", numPP2); 
    printf("numPP2 + 1 address : %p\n", numPP2 + 1);
    
    printf("\n");
    printf("size of numPtr2 : %i\n", sizeof(numPtr2));
    printf("size of *numPtr2 : %i\n", sizeof(*numPtr2));
    printf("size of numPP2 : %i\n", sizeof(numPP2));
    printf("size of *numPP2 : %i\n", sizeof(*numPP2));
    free(numPtr2);
    free(numPP2);

    return 0;
}