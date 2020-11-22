# Binary-Hex-Translator

- Program takes a positive integer as an input and translates it into both binary and hexadecimal values.
- This program uses recursive methods to translate the input into binary and hexadecimal values.
- It is a simple tool that combines two concepts learned in two of my classes:
   1. Computer Engineering - Translating decimal numbers to binary and hexadecimal.
   2. Advanced Data Structures and Software Engineering - Recursive solutions for problems.
   
---
   
The main pieces of code that provide functionality are as follows:

- Recursive binary translator:
```
private String binary(int x, String number)
{
  if (x > 0)
  {
    if (x % 2 == 0)
      number = "0" + number;
    else
      number = "1" + number;

     return binary(x / 2, number);
  }

  return number;
}
``` 
- Recursive hexadecimal translator:
``` 
private String hex(int x, String number)
{
  if (x > 0)
  {
    switch (x % 16)
    {
      case 10:
        number = "A" + number;
        break;
      case 11:
        number = "B" + number;
        break;
      case 12:
        number = "C" + number;
        break;
      case 13:
        number = "D" + number;
        break;
      case 14:
        number = "E" + number;
        break;
      case 15:
        number = "F" + number;
        break;
      default:
        number = (x % 16) + number;
        break;
    }

    return hex(x / 16, number);
  }

  return number;
}
``` 
