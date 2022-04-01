#include <iostream>
#include <cstring>
#include <fstream>

using namespace std;

int main ()
{
  char str[255];
  ifstream fin ("input.txt");
  fin.getline(str, 255);
  cout<<str<<endl;
  bool flag = true;
  string sss = "";
  for(int i = 0; i<sizeof(str); i++) {
    //cout<<str[i]<<endl;
    if ((str[i] == '.') || (str[i] == ',') || (str[i] == ' ')) {
      if((str[i] == ' ') && ((str[i-1] == ',') || (str[i-1] == '.'))) continue;
      if (flag) cout<<sss<<endl;
      else {
        for(int i = sss.size()-1; i>=0; i--)
          cout<<sss[i];
          cout<<endl;
      }
      flag = !flag;
      sss = "";
      continue;
    }

    sss = sss + str[i];
  }

  return 0;
}
