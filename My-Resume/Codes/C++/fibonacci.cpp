#include <stdio.h>
#include <conio.h>
int main()
{
    unsigned long long fibo[100];
    int i{ },j{ };
    fibo[ 0 ] = 1;
    fibo[ 1 ] = 1;
    for ( i = 2 ; i <= 99 ; i++ )
    {   
        fibo[ i ] = fibo[ i - 1 ] + fibo[ i - 2 ];
    }
    int n{ };
    printf("Enter an integer and it will show you n numbers of Fibonacci pattern :\nn = ");
    scanf("%d",&n);
    if ( n >= 1 )
    {
        printf("%llu",fibo[ 0 ]);
        if ( n >= 2 )
        {
            printf(",%llu",fibo[ 1 ]);
            if ( n >= 3 )
            {
                for ( i = 3 ; i <= n ; i++ )
                {
                    printf(",%llu",fibo[ i-1 ]);
                }
            }
        }
    }
    getch ();
    return 0;
}