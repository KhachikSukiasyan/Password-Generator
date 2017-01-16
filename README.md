# Password generator
##DESCRIPTION
Static class in C# for generating passwords with cryptographic sequrity.You can manage the length of your password and what symbols it must contain.

##HOW TO USE
1. Add PasswordClassLibrary namespace to your project.
2. Choose between these functions to generate passwords of different types 
```C#
1. string pinCodeWithDigits(int length, int digit1, int digit2);
2. string pinCodeWithLowerCaseLetters(int length, char lowLetter1, char lowLetter2);
3. string pinCodeWithUpperCaseLetters(int length, char upLetter1, char upLetter2);
4. string pinCodeWithDigitsLowerCaseLetters(int length, int digit1, int digit2, char lowLetter1, char lowLetter2);
5. string pinCodeWithDigitsUpperCaseLetters(int length, int digit1, int digit2, char upLetter1, char upLetter2);
6. string pinCodeWithDifferentCaseLetters(int length, char lowletter1, char lowletter2, char upLetter1, char upLetter2);
7. string pinCodeWithDigitsLetters(int length, int digit1, int digit2, char lowletter1, char lowletter2,
                                                            char upLetter1 , char upLetter2);
```
You also can run the windows form application:

![1](https://github.com/KhachikSukiasyan/Password-Generator/blob/master/Screenshot%20(1).png)

#### 1. Choose the password option you want
#### 2. Select the desired password length
#### 3. Click Generate button
#### 4. If  You want to generate many passwords at a time,turn on the "Multiple passwords".The result will be on another window.
