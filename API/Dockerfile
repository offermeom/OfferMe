FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet clean
RUN dotnet restore
COPY . .
RUN dotnet build --configuration Release --no-restore
RUN dotnet publish --configuration Release --no-build --output ./publish
FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "API.dll"]