KSS.Common.Utility
KSS.Common.Utility is a utility library that provides common functionalities to simplify development tasks. This package includes helper methods, extensions, and utilities for tasks such as string manipulation, data validation, logging, and more.

Installation
You can install the KSS.Common.Utility package via NuGet Package Manager or by using the .NET CLI.

NuGet Package Manager
Open your project in Visual Studio.

Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.

Search for KSS.Common.Utility.

Click Install to add the package to your project.

.NET CLI
Run the following command in your terminal or command prompt:

bash
Copy
dotnet add package KSS.Common.Utility
Usage
Once the package is installed, you can start using the utilities provided by KSS.Common.Utility in your project.

Example: String Extensions
csharp
Copy
using KSS.Common.Utility;

string input = "hello world";
string capitalized = input.CapitalizeFirstLetter(); // Output: "Hello world"
Example: Data Validation
csharp
Copy
using KSS.Common.Utility;

string email = "test@example.com";
bool isValidEmail = Validator.IsValidEmail(email); // Output: true
Example: Logging
csharp
Copy
using KSS.Common.Utility;

Logger.Log("This is an informational message.", LogLevel.Info);
Features
String Extensions: Helper methods for string manipulation.

Data Validation: Utilities for validating emails, phone numbers, etc.

Logging: Simple logging functionality with different log levels.

More Utilities: Additional helper methods for common tasks.

Contributing
We welcome contributions! If you'd like to contribute to KSS.Common.Utility, please follow these steps:

Fork the repository.

Create a new branch for your feature or bug fix.

Make your changes and ensure all tests pass.

Submit a pull request with a detailed description of your changes.

License
This project is licensed under the MIT License. See the LICENSE file for details.

Support
If you encounter any issues or have questions, please open an issue on the GitHub repository.