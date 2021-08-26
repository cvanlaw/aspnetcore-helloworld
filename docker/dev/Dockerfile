FROM mcr.microsoft.com/dotnet/sdk:3.1.412-alpine3.13 AS build-env

WORKDIR /build
COPY ./src .

RUN dotnet restore helloWorld.sln
RUN MSBuildEmitSolution=1 dotnet publish -c Release -o out ./helloWorld/helloWorld.csproj

FROM mcr.microsoft.com/dotnet/aspnet:3.1.18-alpine3.13
WORKDIR /opt/helloWorld
COPY --from=build-env /build/out .

ENTRYPOINT ["dotnet", "/opt/helloWorld/helloWorld.dll"]