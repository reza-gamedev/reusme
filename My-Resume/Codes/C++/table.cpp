#include <iostream>
#include <conio.h>
int main()
{
    int x[ 10 ][ 10 ];
    int i{ },j{ };
    for ( i = 0 ; i <= 9 ; i++ )
    {
        for ( j = 0 ; j <= 9 ; j++ )
        {   
            x[ i ][ j ] = ( i + 1 )*( j + 1 );
            printf("%4d",x[ i ][ j ]);
            if ( j == 9 )
            {
                printf("\n");
            }
        }
    }
    getch ();
    return 0;
}