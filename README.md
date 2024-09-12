# Image Compressor

This repository contains a simple yet powerful image compressor built using ASP.NET Core. The goal of this project is to provide an easy way to upload and optimize images by reducing their file size while maintaining the image quality as much as possible.

## Features

- **Image Upload**: Allows users to upload images.
- **Image Compression**: Compresses the uploaded images to reduce file size without significant quality loss.
- **ASP.NET Core**: Built with ASP.NET Core MVC 8 for modern web application architecture.

## Prerequisites

Before running the project, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 8 or later)
- Any preferred IDE that supports ASP.NET Core projects (Visual Studio, VS Code, etc.)

## How to Run

1. Clone the repository:

    ```bash
    git clone https://github.com/naazeri/Image-Compressor.git
    ```

2. Navigate to the project directory:

    ```bash
    cd Image-Compressor
    ```

3. Restore the dependencies:

    ```bash
    dotnet restore
    ```

4. Run the application:

    ```bash
    dotnet run
    ```

## Usage

- Navigate to the image upload section to upload an image.
- The application will automatically compress the uploaded image.
- You can find the compressed images after the process completes in `wwwroot/images` directory.

## Contributions

Contributions, issues, and feature requests are welcome! Feel free to check the [issues page](https://github.com/naazeri/Image-Compressor/issues).

## License

This project is licensed under the MIT License.
