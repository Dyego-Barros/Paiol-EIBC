FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY . ./

RUN dotnet build
RUN dotnet Publish -c realease -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish ./

ENTRYPOINT ["dotnet","Paiol-EIBC.dll"]