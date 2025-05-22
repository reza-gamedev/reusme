#include <iostream>
int main(){
    char x[100];
    int len = 0;
    int i = 0;
    int k = 0;
    gets(x);
    while (x[i] != '\0'){
        len++;
        i++;
    }
    for (int j = 0;j <= len - 1;j++){
    if (x[j] != ' '&& x[j + 1] != ' ' && x[j + 2] != ' ' && x[j + 3] && (x[j + 4] == '\0' || x[j + 4] == ' ')){
        x[j] = 'L';
        x[j + 1] = 'O';
        x[j + 2] = 'V';
        x[j + 3] = 'E';
    }
    }
    puts(x);
}