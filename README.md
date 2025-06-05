# AstrumUtilityApp

AstrumUtilityApp is a multifunctional, console-based data generator designed for developers, testers, and anyone who needs quick access to various types of generated data. The application provides a user-friendly terminal interface and a selection of generators for common real-world test data.

---

## Features

- **Name Generator**: Produces realistic first names.
- **Password Generator**: Creates strong, random passwords.
- **Email Generator**: Generates valid-looking email addresses.
- **Account Data Generator**: Compiles complete account sets.
- **Key Generator**: Generates cryptographic keys.
- **Phone Number Generator**: Produces phone numbers for forms and testing.
- **Text Generator**: Generates placeholder text (e.g., Lorem Ipsum).
- **Hash Generator**: Calculates hashes for strings or files.
- **Tunnel Generator**: Manages or generates tunnel data for networking tasks.

---

## Usage

1. **Launch the application**  
   Run the executable in your terminal:
   ```bash
   ./AstrumUtilityApp
   ```
   or, if using the .NET runtime:
   ```bash
   dotnet AstrumUtilityApp.dll
   ```

2. **Select a menu item**  
   Enter the corresponding number for the desired generator.

3. **Follow the prompts**  
   The app will guide you through any additional input required.

---

## Example

![image](https://github.com/user-attachments/assets/0767673b-1ae4-47eb-aecf-3f1694df34df)
![image](https://github.com/user-attachments/assets/5f5c15b2-5baa-4ac8-96c6-be73847aa46a)

---

## Requirements

- .NET 8.0 or newer (only required for framework-dependent build)
- macOS, Linux, or Windows

For self-contained builds, no additional dependencies are required.

---

## Building from Source

1. Clone the repository:
   ```bash
   git clone https://github.com/StdAstrum/UtilityApp.git
   cd UtilityApp
   ```
2. Publish for your platform (example for macOS ARM64 self-contained):
   ```bash
   dotnet publish -c Release -r osx-arm64 --self-contained true
   ```
   For other platforms, change `-r` to `win-x64`, `linux-x64`, etc.

---

## License

This project is licensed under the Astrum Products License(APL).

---

## Credits

- Uses open-source libraries such as [Bogus](https://github.com/bchavez/Bogus) and others for realistic data generation.

---

## Contributing

Pull requests and suggestions are welcome!  
For major changes, please open an issue first to discuss what you would like to change.

---
