
#include<iostream>
using namespace std;


int NumStudents;
string name,sub,marks;
cout<<"enter no of students";
cin>>NumStudents;
string myArray[NumStudents][3];
 

for (int i= 0 ; i<NumStudents ; i++){
    cout<<"enter name of student "<<i+1;
    cin>>name;
    cout<<"enter subject of student "<<i+1;
    cin>>sub;
    cout<<"enter marks of student "<<i+1;
    cin>>marks;

        myArray[0][i]= name;
        myArray[1][i]= sub;
        myArray[2][i]= marks;
    
}
for (x=0;x<NumStudents;x++){
for (j=0;j<3;j++){
    cout<<myArray[i][j];
}
cout<<endl;
}