# Password generator
##DESCRIPTION
Simple static class in C# for generating HEX codes with cryptographic sequrity.
Includes one function.
##HOW TO USE
1. Add PasswordClassLibrary namespace to your project.
2. Call NewPinCode function.This function takes only length of password.
example:
```C#
for (int i = 0; i < count; i++)
 {
    Console.WriteLine(PasswordClass.NewPinCode(length));
 }
