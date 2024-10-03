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
