#include <stdio.h> 
#include <stdbool.h>    // bool ����ϱ� ���� �ҷ���
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
            // �κ����տ� ��ġ�ϴ��� Ȯ���ϴ� ����
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

            // ���� ���ڸ� ����ߴٸ� ���⸦ ����ϵ��� ������.
            if (is_equals) {
                printf(" ");
            }
        }
        printf("\n");
    }
}
int main()
{
    printf("A������ �Է��Ͻÿ�:");
    scanf("%s", ary);
    printPowerSet(ary, strlen(ary));
    return 0;
}