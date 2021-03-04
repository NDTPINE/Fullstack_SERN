From mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
From mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

COPY /bin/Release/netcoreapp3.1/publish/ SportStore/
ENV ASPNETCORE_ENVIORONMENT Production

EXPOSE 8000
WORKDIR /SportStore
ENTRYPOINT ["dotnet", "SportStore.dll"]
