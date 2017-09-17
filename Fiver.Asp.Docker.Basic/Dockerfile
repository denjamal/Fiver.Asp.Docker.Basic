# Build Stage
FROM microsoft/aspnetcore-build:2 as build-env
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -o /publish

# Publish Stage
FROM microsoft/aspnetcore:2
WORKDIR /publish
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "Fiver.Asp.Docker.Basic.dll"]