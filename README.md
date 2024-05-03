# Command Line Interface (CLI) Application

This is a simple Command Line Interface (CLI) application implemented in C# that mimics basic functionalities of the Windows command prompt (cmd).

## Features

- **md:** Create a new directory.
- **rd:** Remove an existing directory.
- **cd:** Change the current working directory.
- **create:** Create a new file and input data into it.
- **type:** Display the contents of a file.
- **copy:** Copy a file.
- **del:** Delete a file.
- **append:** Append data to an existing file.
- **dir:** List directories and files in the current directory based on a specified pattern.
- **exit:** Exit the application.

## Getting Started

To run this application, you need to have [.NET Core](https://dotnet.microsoft.com/download) installed on your system.

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or any preferred C# IDE.
3. Build and run the project.

## Usage

Once the application is running, you can use the following commands:

- **md [directory_name]:** Creates a new directory.
- **rd [directory_name]:** Removes an existing directory.
- **cd [directory_name]:** Changes the current working directory.
- **create [file_name]:** Creates a new file and prompts for input data.
- **type [file_name]:** Displays the contents of a file.
- **copy [source_file] [destination_file]:** Copies a file.
- **del [file_name]:** Deletes a file.
- **append [file_name]:** Appends data to an existing file.
- **dir [pattern]:** Lists directories and files in the current directory based on the specified pattern.
- **exit:** Exits the application.

## Example

```cmd
> md new_directory
> cd new_directory
new_directory>
```

## Notes

- This application only supports basic functionalities and may not cover all features of the actual Windows command prompt.
- Use commands carefully, as they can modify or delete files and directories.

Feel free to contribute to this project by adding more features or improving existing ones. If you encounter any issues or have suggestions, please open an issue on GitHub.
