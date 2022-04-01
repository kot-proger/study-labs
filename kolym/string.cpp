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
  char * pch = strtok (str," ,.-");
  bool flag = true;
  while (pch != NULL)
  {
      char *ch = pch;
      if(flag) cout << pch  << "\n";
      else {
        for(int i = sizeof(ch)-2; i>=0; i--)
          cout<<ch[i];
        cout<<endl;
      }
      flag = !flag;
      pch = strtok (NULL, " ,.");
  }
  return 0;
}
