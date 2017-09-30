FROM microsoft/dotnet:2.0.0-sdk-jessie AS build-env

WORKDIR /build
COPY ./src .

RUN dotnet restore helloWorld.sln
RUN MSBuildEmitSolution=1 dotnet publish -c Release -o out ./helloWorld/helloWorld.csproj

FROM microsoft/aspnetcore:2.0.0-jessie
WORKDIR /opt/helloWorld
COPY --from=build-env /build/helloWorld/out .

ENTRYPOINT ["dotnet", "/opt/helloWorld/helloWorld.dll"]