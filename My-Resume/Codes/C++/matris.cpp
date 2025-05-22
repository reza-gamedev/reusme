#include <iostream>
#include <conio.h>
void ShowMatris1();
void ShowMatris2();
int main()
{
    int x[ 3 ][ 3 ];
    int i{ },j{ };
    ShowMatris1();
    for ( i = 0 ; i < 3 ; i++ )//getting variables
    {
        for ( j = 0 ; j < 3 ; j++ )
        {   
            printf("x[ %d ][ %d ] = ",i+1,j+1);
            scanf("%d",&x[ i ][ j ]);
        }
    }
    printf("\n\n");
    ShowMatris2();
    int y[ 3 ][ 3 ];
    for ( i = 0 ; i < 3 ; i++ )//getting variables
    {
        for ( j = 0 ; j < 3 ; j++ )
        {   
            printf("y[ %d ][ %d ] = ",i+1,j+1);
            scanf("%d",&y[ i ][ j ]);
        }
    }
    int xy[ 9 ];//x[ 3 ][ 3 ] * y[ 3 ][ 3 ]
    xy[ 0 ] = (x[ 0 ][ 0 ]*y[ 0 ][ 0 ])+(x[ 0 ][ 1 ]*y[ 1 ][ 0 ])+(x[ 0 ][ 2 ]*y[ 2 ][ 0 ]);
    xy[ 1 ] = (x[ 0 ][ 0 ]*y[ 0 ][ 1 ])+(x[ 0 ][ 1 ]*y[ 1 ][ 1 ])+(x[ 0 ][ 2 ]*y[ 2 ][ 1 ]);
    xy[ 2 ] = (x[ 0 ][ 0 ]*y[ 0 ][ 2 ])+(x[ 0 ][ 1 ]*y[ 1 ][ 2 ])+(x[ 0 ][ 2 ]*y[ 2 ][ 2 ]);
    xy[ 3 ] = (x[ 1 ][ 0 ]*y[ 0 ][ 0 ])+(x[ 1 ][ 1 ]*y[ 1 ][ 0 ])+(x[ 1 ][ 2 ]*y[ 2 ][ 0 ]);
    xy[ 4 ] = (x[ 1 ][ 0 ]*y[ 0 ][ 1 ])+(x[ 1 ][ 1 ]*y[ 1 ][ 1 ])+(x[ 1 ][ 2 ]*y[ 2 ][ 1 ]);
    xy[ 5 ] = (x[ 1 ][ 0 ]*y[ 0 ][ 2 ])+(x[ 1 ][ 1 ]*y[ 1 ][ 2 ])+(x[ 1 ][ 2 ]*y[ 2 ][ 2 ]);
    xy[ 6 ] = (x[ 2 ][ 0 ]*y[ 0 ][ 0 ])+(x[ 2 ][ 1 ]*y[ 1 ][ 0 ])+(x[ 2 ][ 2 ]*y[ 2 ][ 0 ]);
    xy[ 7 ] = (x[ 2 ][ 0 ]*y[ 0 ][ 1 ])+(x[ 2 ][ 1 ]*y[ 1 ][ 1 ])+(x[ 2 ][ 2 ]*y[ 2 ][ 1 ]);
    xy[ 8 ] = (x[ 2 ][ 0 ]*y[ 0 ][ 2 ])+(x[ 2 ][ 1 ]*y[ 1 ][ 2 ])+(x[ 2 ][ 2 ]*y[ 2 ][ 2 ]);
    for ( i = 0 ; i < 3 ; i++ )
    {
        for ( j = 0 ; j < 3 ; j++ )
        {   
            
            printf("%4d",x[ i ][ j ]);
            if ( j == 2 )
            {
                printf("\n");
            }
        }
    }
    printf("      * *\n       *\n      * *\n");
    for ( i = 0 ; i < 3 ; i++ )
    {
        for ( j = 0 ; j < 3 ; j++ )
        {   
            
            printf("%4d",y[ i ][ j ]);
            if ( j == 2 )
            {
                printf("\n");
            }
        }
    }
    printf("      ===\n      ===\n");
    for ( i = 0 ; i <= 8 ; i++)
    {
       
        printf("%4d",xy[ i ]);
        if (i == 2 || i == 5)
        {
            printf("\n");
        }
    }
    getch ();
    return 0;
}
void ShowMatris1()
{
    int i{ },j{ };
    for ( i = 0 ; i < 3 ; i++ )//namayeshe matrise x
    {
        for ( j = 0 ; j < 3 ; j++ )
        {   
            printf("x[ %d ][ %d ]   ",i+1,j+1);
            if ( j == 2 )
            {
                printf("\n\n");
            }
        }
    }
}
void ShowMatris2()
{
    int i{ },j{ };
    for ( i = 0 ; i < 3 ; i++ )//namayeshe matrise x
    {
        for ( j = 0 ; j < 3 ; j++ )
        {   
            printf("y[ %d ][ %d ]   ",i+1,j+1);
            if ( j == 2 )
            {
                printf("\n\n");
            }
        }
    }
}