#include <stdio.h> 
#include <stdbool.h>    // bool 사용하기 위해 불렀음
#include <string.h>
#include <math.h> 
#define MAX 1000

char ary[MAX] = { 0 };

unsigned int countSetBits(unsigned int n)
{
    unsigned int count = 0;
    while (n) {
        count += n & 1;
        n >>= 1;
    }
    return count;
}

void printPowerSet(char* set, int set_size)
{
    unsigned int pow_set_size = pow(2, set_size);
    int counter, j, k;

    for (counter = 0; counter <= set_size; counter++)
    {
        printf("%d:", counter);

        for (j = 0; j < pow_set_size; j++)
        {
            // 부분집합에 일치하는지 확인하는 변수
            bool is_equals = false;
            for (k = 0; k < set_size; k++)
            {
                if (j & (1 << k))
                {
                    if (countSetBits(j << k) == counter)
                    {
                        printf("%c", set[k]);
                        is_equals = true;
                    }
                }
            }

            // 만약 문자를 출력했다면 띄어쓰기를 출력하도록 변경함.
            if (is_equals) {
                printf(" ");
            }
        }
        printf("\n");
    }
}
int main()
{
    printf("A집합을 입력하시오:");
    scanf("%s", ary);
    printPowerSet(ary, strlen(ary));
    return 0;
}