# Build Stage
FROM microsoft/aspnetcore-build AS build-env

WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet build
ENV TEAMCITY_PROJECT_NAME=fake
RUN dotnet test ./Fiver.Asp.Docker.Basic.Tests --verbosity=normal

WORKDIR /src/Fiver.Asp.Docker.Basic
RUN dotnet publish -o /publish --configuration Release

# Publish Stage
FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "Fiver.Asp.Docker.Basic.dll"]