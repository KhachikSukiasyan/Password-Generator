# Password
-----DESCRIPTION
Static class for generating HEX codes with cryptographic sequrity,includes one function.
-----HOW TO USE
1.Add PasswordClassLibrary namespace to your project.
2.Call NewPinCode function.This function takes only length of password;
  example:
          for (int i = 0; i < count; i++)
          {
              Console.WriteLine(PasswordClass.NewPinCode(length));
          }
