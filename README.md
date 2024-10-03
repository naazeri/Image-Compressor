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

# Image Uploader with Optimization - ASP.NET Core MVC 8

This project is an ASP.NET Core MVC 8 application that allows users to upload multiple images (up to 100 images at once, with each image up to 50 MB). The images are uploaded to a server, optimized, and stored in a separate directory. Users are shown progress while the optimization is happening and are notified once the process is complete.

## Features

- **Multiple Image Uploads**: Upload up to 100 images in a single batch.
- **File Size Restriction**: Each image file is restricted to a maximum size of 50 MB.
- **Image Optimization**: Images are processed and optimized after upload. The optimized images are stored in a separate directory.
- **Loading Indication**: Users are notified while the optimization process is taking place.
- **No Authentication**: This project does not include any user authentication.

## Requirements

- .NET SDK 8.0
- Visual Studio or any code editor with .NET Core support

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/ImageUploader.git
cd ImageUploader
```
