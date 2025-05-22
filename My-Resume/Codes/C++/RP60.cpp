#include <iostream>
int main(){
    char s1[50];
    char s2[50];
    int Len_s1 = Len(s1);
    int Len_s2 = Len(s2);
    gets(s1);
    gets(s2);
}
void finder(char s1[],char s2[]){
    
}
int Len(char s[]){
    int i = 0;
    int len = 0;
    while (s[i] != '\0'){
        len++;
    }
    return len;
}