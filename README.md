### Command line statements Dotnet

## dotnet -l

Liệt kê danh sách chức năng dotnet hỗ trợ

## dotnet new -l

Liệt kê danh sách các loại ứng dụng có thể tạo từ dotnet

## dotnet new <type_app>

Tạo mới application với loại ứng dụng chỉ định

# dotnet new console

Tạo mới một ứng dụng console

## dotnet run

Chạy chương trình

## dotnet build

Build chương trình

## dotnet publish <tag_name> <folder_name>

# dotnet publish

Đóng gói ứng dụng cho khách hàng, mặc định là thư mục publish

# dotnet publish -c Release

Đóng gói ứng dụng trong thư mục Release

## dotnet add package <package-name> [--version xxx]

Thêm package từ nuget vào dự án

## dotnet remove package <package-name>

Xoá package khỏi dự án

## dotnet restore

fix các package không chạy dc, hoặc cài đặt lại package đó vào dự án

## dotnet add <project-name-1.csproj> reference <project-name-2.csproj>

Thêm thư viện project-name-2.csproj vào trong project-name-1.csproj

- Cần chỉ định rõ đường dẫn của 2 dự án này
- project-name-2.csproj là loại dự án library
- Đây là cách tham chiếu trực tiếp
- Khi cập nhật code ở lib project-name-2 thì ta chỉ cần build lại trong project-name-1
  thì có thể cập nhật code mới nhất trong lib project-name-2

## dotnet pack

Đóng gói thư viện thành file có đuôi .nupkg để đưa lên nuget

## dotnet nuget push <filen-name.nupkg> --api-key <key-lay-tu-nuget> --source https://api.nuget.org/v3/index.json

Đẩy lib lên nuget

##### Cách public lib lên nuget

b1: Đăng nhập tài khoản vào nuget
b2: Tạo api key
b3: Đóng gói thư viện thành file có đuôi .nupkg
b4: Đẩy thư viện đã đóng gói lên nuget

## dotnet dev-certs https --trust

Cơ chế chạy an toàn dưới local
